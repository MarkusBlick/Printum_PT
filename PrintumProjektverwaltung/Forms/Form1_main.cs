using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using PrintumProjektverwaltung.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using DevExpress.XtraReports.UI;
using PrintumProjektverwaltung.DAL;
using System.Diagnostics;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Form1_main : Form
    {
        public string folderroot;

        public ExchangeService service;
        public ContactsFolder contactsfolder;
        public FindItemsResults<Item> contactItems;
        public List<Contact> alleAdressen;
        public printumUser derUser;


        private List<printumProjekt> alleProjekte;

        private List<printumBestellPositionen> akutelleBestellung;

        private TreeView treeviewCach;

        internal List<printumProjekt> AlleProjekte { get => alleProjekte; set => alleProjekte = value; }


        private DataGridViewCellEventArgs mouseLocation;

        public Form1_main()
        {
            InitializeComponent();

            // Switch für die Entwicklungsumgebung, 
            // .. die ist nicht im Firmennetzt deshalb funktionieren nur nackte IPs
            if (Directory.Exists(@"\\PRINTUMSERVER\PT-99-Vorl"))
            {
                folderroot = @"\\PRINTUMSERVER\";
            }
            else
            {
                folderroot = @"\\192.168.26.250\";
            }


            // Konstruktor usw für die Outlookadressen
            service = new ExchangeService(ExchangeVersion.Exchange2013);
            service.Url = new Uri("https://outlook.office365.com/ews/exchange.asmx");
            service.Credentials = new WebCredentials("info@printum.de", "#PR1n+um#");
            service.TraceEnabled = true;
            service.TraceFlags = TraceFlags.All;
            alleAdressen = new List<Contact>();
            treeviewCach = new TreeView();
        }
        private void Form1_main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet11.BestellungPositionen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bestellungPositionenTableAdapter.FillBy(this.dataSet11.BestellungPositionen);

            // TODO: This line of code loads data into the 'dataSet1.Bestellungen' table. You can move, or remove it, as needed.
            this.bestellungenTableAdapter.Fill(this.dataSet11.Bestellungen);
            this.label_Datum.Text = DateTime.Now.Date.ToString().Substring(0, 10) + "   PT-PriPro (" + System.Windows.Forms.Application.ProductVersion + ")";

            //derUser = new printumUser();
            //derUser.getUserFromAD(Environment.UserName);

            this.label_user.Text = System.Environment.UserName;

            AlleProjekte = loadDieProjekte();

            Helper.buildTree.addProjekte(this.treeView1, AlleProjekte);


            this.bestellungenDataGridView.ClearSelection();
            bestellungPositionenDataGridView.Visible = false;


            //  BeginInvoke((Action)(() => GetItemsAsync()));
            adressenAsyncLaden();
        }

        public void adressenAsyncLaden()
        {
            if (alleAdressen.Count > 0)
            {
                alleAdressen.Clear();
            }
            this.timer2_displayAdressen.Start();
            System.Threading.Tasks.Task task = System.Threading.Tasks.Task.Run(() => GetItemsAsync());

        }

        private List<printumProjekt> loadDieProjekte()
        {

            List<printumProjekt> dieListe = new List<printumProjekt>();
            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {
                var dbProjekte = from p in db.Projekte
                                 orderby p.Projektnummer descending
                                 select new printumProjekt
                                 {
                                     Projektnummer = p.Projektnummer,
                                     Projektname = p.Projektname,
                                     Projektbeginn = p.Projektbeginn,
                                     RootOrdner = p.RootOrdner,
                                     Inbetriebname = p.Inbetriebname,
                                     Produktionsbeginn = p.Produktionsbeginn,
                                     aktiv = p.aktiv,
                                     Projektart = p.Projektart
                                 };

                try
                {
                    if (dbProjekte.Count() > 0)
                    {
                        foreach (var item in dbProjekte)
                        {
                            // item.Unterordner = printumOrdner.getOrdnerBy(item.Projektnummer); // T0Do
                            //item.Dateien = printumDatei.getDateienBy(item.Projektnummer); // ToDo
                        }
                        dieListe = dbProjekte.ToList();
                    }
                }
                catch (Exception ex)
                {

                    Helper.LogHelper.WriteDebugLog(ex.ToString());
                }


            }
            return dieListe;
        }


        private void button1_readFolder_Click(object sender, EventArgs e)
        {
            Form5_Projektkosten f5 = new Form5_Projektkosten();
            f5.alleProjekte = AlleProjekte;
            f5.Show();
        }


        private async System.Threading.Tasks.Task GetItemsAsync()
        {
            await System.Threading.Tasks.Task.Delay(3000).ConfigureAwait(false);


            ItemView view = new ItemView(10, 0, OffsetBasePoint.Beginning);

            view.OrderBy.Add(ItemSchema.DateTimeCreated, SortDirection.Descending);

            //this.timer2_displayAdressen.Start();

            do
            {
                contactItems = service.FindItems(WellKnownFolderName.Contacts, view);

                if (contactItems.Count() == 0)
                {
                    var bla = "null";
                }

                foreach (Item item in contactItems)
                {
                    // Do something with the item.
                    if (item is Contact)
                    {
                        Contact cont = (Contact)item;
                        alleAdressen.Add(cont);
                    }


                }

                //any more batches?
                if (contactItems.NextPageOffset.HasValue)
                {
                    view.Offset = contactItems.NextPageOffset.Value;
                }
                else
                {
                    this.timer2_displayAdressen.Stop();

                }
            }
            while (contactItems.MoreAvailable);

        }



        private void button2_neueBestellung_Click(object sender, EventArgs e)
        {
            var tvNode = this.treeView1.SelectedNode;

            if (tvNode == null)
            {
                MessageBox.Show("Wie..." + Environment.NewLine +
                                                   Environment.NewLine +
                                                   "kein Projekt ausgewählt?");
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                printumBestellung neueBestellung = new printumBestellung();
                neueBestellung.Bestellung_ID = neueBestellung.getNextBestellnr();



                try
                {
                    var item = this.treeView1.SelectedNode;

                    printumProjekt currProjekt = (printumProjekt)item.Tag;

                    neueBestellung.Projektnummer = currProjekt.Projektnummer;
                    neueBestellung.ProjektnummerText = currProjekt.Projektnummer.ToString();

                }
                catch (Exception es)
                {
                    var bal = es.ToString();
                }

                Form2_Bestellung FormBestellung = new Form2_Bestellung(neueBestellung, alleAdressen);
                var FormErgebniss = FormBestellung.ShowDialog();

                this.bestellungenTableAdapter.Fill(this.dataSet11.Bestellungen);

                this.Cursor = Cursors.Default;
            }
        }





        private void button_newOder_Click(object sender, EventArgs e)
        {
            var tvNode = this.treeView1.SelectedNode;

            if (tvNode == null)
            {
                MessageBox.Show("Wie..." + Environment.NewLine +
                                                   Environment.NewLine +
                                                   "kein Projekt ausgewählt?");
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                printumBestellung neueBestellung = new printumBestellung();
                neueBestellung.Bestellung_ID = neueBestellung.getNextBestellnr();



                try
                {
                    var item = this.treeView1.SelectedNode;

                    printumProjekt currProjekt = (printumProjekt)item.Tag;

                    neueBestellung.Projektnummer = currProjekt.Projektnummer;
                    neueBestellung.ProjektnummerText = currProjekt.Projektnummer.ToString();

                }
                catch (Exception es)
                {
                    var bal = es.ToString();
                }
                bool isEnglish = true;
                Form2_Bestellung FormBestellung = new Form2_Bestellung(neueBestellung, alleAdressen, isEnglish);
                var FormErgebniss = FormBestellung.ShowDialog();

                this.bestellungenTableAdapter.Fill(this.dataSet11.Bestellungen);

                this.Cursor = Cursors.Default;
            }
        }





        private void button3_neuesProjekt_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Form3_Projekte f3 = new Form3_Projekte();
            f3.ShowDialog();

            AlleProjekte = loadDieProjekte();
            Helper.buildTree.addProjekte(this.treeView1, AlleProjekte);

            this.Cursor = Cursors.Default;

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (this.treeView1.SelectedNode != null)
            {
                printumProjekt currP = (printumProjekt)this.treeView1.SelectedNode.Tag;
                if (currP.RootOrdner != null)
                {
                    var pfad = currP.RootOrdner.Trim();
                    if (this.folderroot.Contains("192.168.26.250"))
                    {
                        pfad = pfad.Replace("PRINTUMSERVER", "192.168.26.250");
                    }

                    System.Diagnostics.Process.Start(pfad);
                }

            }
            this.Cursor = Cursors.Default;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.bestellungPositionenDataGridView.Visible = false;

            printumProjekt dasProjekt = (printumProjekt)this.treeView1.SelectedNode.Tag;
            if (dasProjekt != null)
            {
                string projekt = dasProjekt.Projektnummer.ToString();

                string filtertext4 = "CONVERT(Projektnummer, 'System.String') LIKE '*" + projekt + "*'";

                this.bestellungenBindingSource.Filter = filtertext4;
                this.bestellungenDataGridView.ClearSelection();

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Helper.buildTree.filter(this.treeView1, AlleProjekte, this.textBox1.Text);


        }

        private void bestellungenDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.bestellungenDataGridView.CurrentRow;

            if (row != null)
            {
                string pfadPDF = "";
                string pfadEXCEL = "";

                var zelleExcel = row.Cells["speicherortDataGridViewTextBoxColumn"];
                if (zelleExcel != null)
                {
                    pfadEXCEL = zelleExcel.Value.ToString();

                }

                var zellePDF = row.Cells["PDFpfad"];
                if (zellePDF != null)
                {
                    pfadPDF = zellePDF.Value.ToString();

                }

                // switch für die Entwicklungsumgebung

                if (this.folderroot.Contains("192.168.26.250"))
                {
                    pfadPDF = pfadPDF.Replace("PRINTUMSERVER", "192.168.26.250");
                    pfadEXCEL = pfadEXCEL.Replace("PRINTUMSERVER", "192.168.26.250");
                }


                if (File.Exists(pfadPDF))
                {

                    System.Diagnostics.Process.Start(pfadPDF);



                }
                else
                {
                    if (File.Exists(pfadEXCEL))
                    {

                        System.Diagnostics.Process.Start(pfadEXCEL);

                    }
                    else
                    {
                        MessageBox.Show("Die Datei gibt es nicht (oder nicht mehr...).");
                    }
                }
            }
        }


        private void button_loeschen_Click(object sender, EventArgs e)
        {
            bool istBestellungausgewählt = this.bestellungenDataGridView.SelectedRows.Count == 1;

            if (istBestellungausgewählt)
            {
                var row = this.bestellungenDataGridView.CurrentRow;

                if (row != null)
                {
                    if (row.Cells["istAbgeschickt"].Value != null)
                    {

                    }
                    else
                    {
                        schonAbgeschickt(row, "  Kann also nicht mehr gelöscht werden.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte eine  Bestellung auswählen!");
            }
        }

        private void button4_mail_Click(object sender, EventArgs e)
        {

            bool istBestellungausgewählt = this.bestellungenDataGridView.SelectedRows.Count == 1;

            if (istBestellungausgewählt)
            {

                var row = this.bestellungenDataGridView.CurrentRow;

                if (row != null)
                {
                    if (row.Cells["istAbgeschickt"].Value != null)
                    {
                        bool istAbgeschickt;
                        bool.TryParse(row.Cells["istAbgeschickt"].Value.ToString(), out istAbgeschickt);
                        if (istAbgeschickt == false)
                        {

                            var zelle1 = row.Cells["speicherortDataGridViewTextBoxColumn"];
                            if (zelle1 != null)
                            {
                                string pfad = zelle1.Value.ToString();
                                var email = row.Cells["EmailAdresse"].Value.ToString();
                                var bestellnr = row.Cells["bestellungIDTextDataGridViewTextBoxColumn"].Value.ToString();
                                var projektnr = row.Cells["projektnummerDataGridViewTextBoxColumn"].Value.ToString();
                                int projetnrInt = 0;
                                int.TryParse(projektnr, out projetnrInt);


                                // Switch für die Entwicklungsumgebung, 
                                // .. die ist nicht im Firmennetzt deshalb funktionieren nur nackte IPs
                                if ((!File.Exists(pfad)) && pfad.Contains(@"\\PRINTUMSERVER\"))
                                {
                                    pfad = pfad.Replace(@"\\PRINTUMSERVER\", @"\\192.168.26.250\");
                                }

                                if (File.Exists(pfad))
                                {
                                    this.button4_mail.Enabled = false;

                                    Form4_Spinner f4 = new Form4_Spinner();
                                    f4.ShowDialog();


                                    akutelleBestellung = Helper.OutlookHelper.createNewEmailmitAnhang(pfad, bestellnr, projetnrInt, email);

                                    // jetzt die mail überwachen.

                                }
                            }
                            else
                            {
                                MessageBox.Show("Die Datei gibt es nicht (oder nicht mehr...).");
                            }


                        }
                        else // wurde schon abgeschickt
                        {
                            schonAbgeschickt(row, "");
                        }


                    }
                    else
                    {
                        schonAbgeschickt(row, "");
                    }
                }


            }
            else
            {
                MessageBox.Show("Bitte eine  Bestellung auswählen!");
            }
        }

        private void schonAbgeschickt(DataGridViewRow row, string msg)
        {

            string txt = "Die Bestellung wurde schon abgeschickt! " + msg + Environment.NewLine + Environment.NewLine;
            DateTime datum;
            if (DateTime.TryParse(row.Cells["datumDataGridViewTextBoxColumn"].Value.ToString(), out datum))
            {
                txt += " am: " + datum.ToLongDateString() + "  um: " + datum.ToShortTimeString() + Environment.NewLine;
                txt += " von: " + row.Cells["GeaendertVon"].Value.ToString();
            }
            MessageBox.Show(txt);
        }


        public void BestellungenNeuLaden()
        {
            this.bestellungenTableAdapter.Fill(this.dataSet11.Bestellungen);
            this.bestellungPositionenTableAdapter.FillBy(this.dataSet11.BestellungPositionen);
        }

        private void button5_alleBestellungenanzeigen_Click(object sender, EventArgs e)
        {
            this.bestellungenBindingSource.Filter = "BestellungIDText LIKE '*'";
            bestellungPositionenDataGridView.Visible = false;

        }


        private void bestellungenDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.button4_mail.Enabled = true;

            var row = this.bestellungenDataGridView.CurrentRow;

            if (row != null)
            {

                if (row.Selected)
                {
                    string bestellnr = row.Cells["bestellungIDTextDataGridViewTextBoxColumn"].Value.ToString();

                    string filtertext = "BestellnungIDTest LIKE '" + bestellnr + "'";
                    this.bestellungPositionenBindingSource.Filter = filtertext;

                    bestellungPositionenDataGridView.Visible = true;
                    schreibgeschutztMachen();
                    FormatDataGridView(this.bestellungPositionenDataGridView);

                }
                else
                {
                    bestellungPositionenDataGridView.Visible = false;
                }
            }
        }



        private void button6_WE_Click(object sender, EventArgs e)
        {
            //Form6_WE f6;
            //if (this.bestellungenDataGridView.SelectedRows.Count == 1)
            //{
            //    string bestllnr = this.bestellungenDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //    f6 = new Form6_WE(bestllnr);
            //}
            //else
            //{
            //    f6 = new Form6_WE();
            //}

            //f6.Show();

            this.panel16_Speichern.Visible = true;
            this.label_speichern.Text = "Wareneingangsdatum und Lagerort können geändert werden";


            this.bestellungPositionenDataGridView.ReadOnly = false;

            this.bestellungPositionenDataGridView.Columns["WE_datum"].ReadOnly = false;
            this.bestellungPositionenDataGridView.Columns["Lagerort"].ReadOnly = false;

        }

        private void button7_Auftragsbestaetigung_Click(object sender, EventArgs e)
        {


            this.panel16_Speichern.Visible = true;
            this.label_speichern.Text = "Liefertermin laut AB und Preise können geändert werden";

            this.bestellungPositionenDataGridView.ReadOnly = false;

            // this.bestellungPositionenDataGridView.Columns["Liefertermin"].ReadOnly = false;
            this.bestellungPositionenDataGridView.Columns["AB_datum"].ReadOnly = false;
            this.bestellungPositionenDataGridView.Columns["Einzelpreis"].ReadOnly = false;
            this.bestellungPositionenDataGridView.Columns["Gesammtpreis"].ReadOnly = false;
        }

        private void button8_Adressen_Click(object sender, EventArgs e)
        {
            Form8_Adressen f8 = new Form8_Adressen();
            // f8.alleAdressen = alleAdressen;

            f8.Show();


        }

        private void label1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            adressenAsyncLaden();
            loadDieProjekte();
            BestellungenNeuLaden();

            this.Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void timer1_tableLoad_Tick(object sender, EventArgs e)
        {
            // this.label1.Text = "Projekte (nachladen)";
            AlleProjekte = loadDieProjekte();
            Helper.buildTree.addProjekte(this.treeView1, AlleProjekte);
            BestellungenNeuLaden();
            // this.label1.Text = "Projekte";

        }

        // rechte Maus aktiviert die Node
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
        }

        private void toolStripMenuItem1_projektname_Click(object sender, EventArgs e)
        {
            var derTag = this.treeView1.SelectedNode.Tag;
            if (derTag != null)
            {
                Form1_1_Projektname f11 = new Form1_1_Projektname(derTag);
                f11.ShowDialog();

                AlleProjekte = loadDieProjekte();
                Helper.buildTree.addProjekte(this.treeView1, AlleProjekte);
            }
        }


        private void toolStripMenuItem2_projektart_Click(object sender, EventArgs e)
        {
            var derTag = this.treeView1.SelectedNode.Tag;
            if (derTag != null)
            {
                Form1_2_Projektart f12 = new Form1_2_Projektart(derTag);
                f12.ShowDialog();

                AlleProjekte = loadDieProjekte();
                Helper.buildTree.addProjekte(this.treeView1, AlleProjekte);
            }
        }



        private void projektLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var derTag = this.treeView1.SelectedNode.Tag;
            if (derTag != null)
            {
                printumProjekt dasP = (printumProjekt)derTag;

                var sollIch = MessageBox.Show("Soll das Projekt " + dasP.Projektnummer.ToString()
                    + " " + dasP.Projektname + " wirklich GELÖSCHT werden?", "LÖSCHEN", MessageBoxButtons.OKCancel);

                if (sollIch == DialogResult.OK)
                {
                    Helper.ProjekteHelper.deleteProjekt(dasP);
                }
            }

        }





        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tooltext = "Die nächste Bestellnummer ist : " + Environment.NewLine + Environment.NewLine;

            try
            {

                printumBestellung neueBestellung = new printumBestellung();
                neueBestellung.Bestellung_ID = neueBestellung.getNextBestellnr();

                tooltext += "   " + neueBestellung.BestellungIDText + Environment.NewLine + "   . ";

                MessageBox.Show(tooltext);

            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }



        private void button8_Adressen_MouseEnter(object sender, EventArgs e)
        {
            this.button8_Adressen.Text = "Adressen (" + alleAdressen.Count.ToString() + ")";
        }

        private void timer2_displayAdressen_Tick(object sender, EventArgs e)
        {
            this.button8_Adressen.Text = "Adressen (" + alleAdressen.Count.ToString() + ")";

        }

        private void button9_baugruppe_Click(object sender, EventArgs e)
        {
            Form10_Baugruppe f10 = new Form10_Baugruppe();
            f10.Show();
        }

        private void button10_Auslieferung_Click(object sender, EventArgs e)
        {
            Ausliefer01_main AuslieferungForm01 = new Ausliefer01_main();
            AuslieferungForm01.Show();
        }

        private void button_lieferschein_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var zahl = getSelectedBestellID();
            ReportViewer1 R1 = new ReportViewer1(zahl);

            R1.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private int getSelectedBestellID()
        {
            int dieID = 0;
            var dieRows = this.bestellungenDataGridView.SelectedRows;
            if (dieRows.Count > 0)
            {
                try
                {
                    var val = dieRows[0].Cells["Bestellung_ID"].Value.ToString();

                    Int32.TryParse(val, out dieID);

                }
                catch (Exception ex)
                {
                    Helper.LogHelper.WriteDebugLog(ex.ToString());
                }
            }
            return dieID;

        }

        private void button12_Einheit_Click(object sender, EventArgs e)
        {
            Ausliefer07_Einheit f07 = new Ausliefer07_Einheit();
            f07.ShowDialog();
        }

        private void button11_Artikel_Click(object sender, EventArgs e)
        {
            Ausliefer08_Artikel f08 = new Ausliefer08_Artikel();
            f08.ShowDialog();
        }

        private void button_aenderungSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bestellungPositionenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet11);
            this.panel16_Speichern.Visible = false;
            this.schreibgeschutztMachen();
        }



        private void schreibgeschutztMachen()
        {
            this.panel16_Speichern.Visible = false;
            this.bestellungPositionenDataGridView.ReadOnly = true;
            //  this.bestellungPositionenDataGridView.Columns["Liefertermin"].ReadOnly = true;
            this.bestellungPositionenDataGridView.Columns["AB_datum"].ReadOnly = true;
            this.bestellungPositionenDataGridView.Columns["WE_datum"].ReadOnly = true;
            this.bestellungPositionenDataGridView.Columns["Einzelpreis"].ReadOnly = true;
            this.bestellungPositionenDataGridView.Columns["Gesammtpreis"].ReadOnly = true;
            this.bestellungPositionenDataGridView.Columns["Lagerort"].ReadOnly = true;
        }

        private void bestellungPositionenDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                var zelle = this.bestellungPositionenDataGridView[e.ColumnIndex, e.RowIndex];


                if (zelle.OwningColumn.Name == "AB_datum")
                {
                    this.bestellungPositionenDataGridView.Rows[e.RowIndex].Cells["ABestaetiger"].Value = Environment.UserName;
                }

                if (zelle.OwningColumn.Name == "WE_datum" || zelle.OwningColumn.Name == "Lagerort")
                {
                    this.bestellungPositionenDataGridView.Rows[e.RowIndex].Cells["WEingaenger"].Value = Environment.UserName;
                }

                //if (zelle.OwningColumn.Name == "WE_datum")
                //{
                //    this.bestellungPositionenDataGridView.Rows[e.RowIndex].Cells["WEingaenger"].Value = Environment.UserName;
                //}
            }
        }


        private void FormatDataGridView(DataGridView dg)
        {
            foreach (DataGridViewRow item in dg.Rows)
            {
                if (item.Cells["Liefertermin"].Value != null && item.Cells["Liefertermin"].Value != System.DBNull.Value)
                {
                    var lieferdate = (DateTime)item.Cells["Liefertermin"].Value;

                    if (item.Cells["AB_datum"].Value != null && item.Cells["AB_datum"].Value != System.DBNull.Value)
                    {
                        var abdate = (DateTime)item.Cells["AB_datum"].Value;


                        if (abdate > lieferdate)
                        {
                            item.Cells["AB_datum"].Style.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        item.Cells["AB_datum"].Style.BackColor = Color.Beige;
                    }


                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start(@"\\192.168.26.250\PT-99-Vorl\Dokumente\Kurzanleitung PriPro.pdf");
        }


        private void icon_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Public\PrintumProjekte\Logs\");
        }

        private void bestellungPositionenDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1
                && this.bestellungPositionenDataGridView.Columns["WE_datum"].ReadOnly == false)
            {
                var zelle = this.bestellungPositionenDataGridView[e.ColumnIndex, e.RowIndex];




                if (zelle.OwningColumn.Name == "WE_datum")
                {
                    this.bestellungPositionenDataGridView.Rows[e.RowIndex].Cells["WE_datum"].Value = DateTime.Now.ToLongDateString();
                    this.bestellungPositionenDataGridView.Rows[e.RowIndex].Cells["WEingaenger"].Value = Environment.UserName;
                }


            }
        }

        private void button11_Lieferscheine_Click(object sender, EventArgs e)
        {
            Lieferschein01_main L01 = new Lieferschein01_main();
            L01.Show();
        }


        private void textBox3_projekt_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox3_projekt.Text.Length > 2)
            {
                bestellungenFiltern();
            }

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length > 2)
            {
                bestellungenFiltern();
            }
        }


        private void bestellungenFiltern()
        {
            this.bestellungPositionenDataGridView.Visible = false;

            string filtertext1, filtertext2, filtertext3, filtertext4;
            string suchtext = this.textBox2.Text.Trim();
            string projekt = this.textBox3_projekt.Text.Trim();


            if (projekt.Length > 2)
            {
                // über Projekte filtern
                filtertext1 = "BestellungIDText LIKE '*" + suchtext + "*'";
                filtertext2 = "CONVERT(Projektnummer, 'System.String') LIKE '*" + projekt + "*'";
                filtertext3 = "Adresse LIKE '*" + suchtext + "*'";
                filtertext4 = "EmailAdresse LIKE '*" + suchtext + "*'";

                this.bestellungenBindingSource.Filter =
                        filtertext2 + " AND ( " +
                        filtertext3 + " OR " +
                        filtertext1 + " OR " +
                        filtertext4 + ")";
            }
            else
            {  // über alle filtern

                filtertext1 = "BestellungIDText LIKE '*" + suchtext + "*'";
                filtertext2 = "CONVERT(Projektnummer, 'System.String') LIKE '*" + suchtext + "*'";
                filtertext3 = "Adresse LIKE '*" + suchtext + "*'";
                filtertext4 = "EmailAdresse LIKE '*" + suchtext + "*'";

                this.bestellungenBindingSource.Filter =
                        filtertext1 + " OR " +
                        filtertext2 + " OR " +
                        filtertext3 + " OR " +
                        filtertext4;
            }




        }

        private void button12_rechnungen_Click(object sender, EventArgs e)
        {
            var R01 = new Rechnung01_main();
            R01.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip3_Bestellung_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_delete_Click(object sender, EventArgs e)
        {
            var row = this.bestellungenDataGridView.Rows[mouseLocation.RowIndex];
            string bestellnr = row.Cells["bestellungIDTextDataGridViewTextBoxColumn"].Value.ToString();

            var antwort = MessageBox.Show(" Bestellung: " + bestellnr + " wirklich löschen? ", "Neee, oder?", MessageBoxButtons.OKCancel);
            if (antwort == DialogResult.OK)
            {
                var a2 = MessageBox.Show(" ...echt?" + Environment.NewLine + Environment.NewLine
                    + " ... dann ist aber alles weg.","",MessageBoxButtons.OKCancel);
                if (a2 == DialogResult.OK)
                {
                    var a3 = MessageBox.Show("Wenn du jetzt nicht Michael Weiss bist, kann das GANZ unangenehm werden....", "Oh-Ha!", MessageBoxButtons.OKCancel);
                    if (a3 == DialogResult.OK)
                    {


                        var pfad = row.Cells[11].Value;
                        if (pfad != null & File.Exists(pfad.ToString()))
                        {
                            try
                            {
                                File.Delete(pfad.ToString());
                            }
                            catch (Exception ex)
                            {
                                Helper.LogHelper.WriteDebugLog(ex.ToString());
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        using (var db = new DAL.PrintumProjekteEntities())
                        {
                            try
                            {
                                var q1 = from p in db.BestellungPositionen
                                         where p.BestellnungIDTest == bestellnr
                                         select p;
                                if (q1.Count() > 0)
                                {
                                    foreach (var item in q1.ToList())
                                    {
                                        db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                                    }
                                    db.SaveChanges();
                                }
                            }
                            catch (Exception ex)
                            {
                                Helper.LogHelper.WriteDebugLog(ex.ToString());
                                MessageBox.Show(ex.ToString());
                            }

                            try
                            {
                                var q2 = from p in db.Bestellungen
                                         where p.BestellungIDText == bestellnr
                                         select p;
                                if (q2.Count() > 0)
                                {
                                    foreach (var item2 in q2.ToList())
                                    {
                                        db.Entry(item2).State = System.Data.Entity.EntityState.Deleted;
                                    }
                                    db.SaveChanges();
                                }
                            }
                            catch (Exception ex)
                            {
                                Helper.LogHelper.WriteDebugLog(ex.ToString());
                                MessageBox.Show(ex.ToString());
                            }




                            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet11.BestellungPositionen". Sie können sie bei Bedarf verschieben oder entfernen.
                            this.bestellungPositionenTableAdapter.FillBy(this.dataSet11.BestellungPositionen);

                            // TODO: This line of code loads data into the 'dataSet1.Bestellungen' table. You can move, or remove it, as needed.
                            this.bestellungenTableAdapter.Fill(this.dataSet11.Bestellungen);


                        }
                        MessageBox.Show("Gelöscht!!");
                    }


                }
            }
        }

        private void bestellungenDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.mouseLocation = e;
        }
    }
}

