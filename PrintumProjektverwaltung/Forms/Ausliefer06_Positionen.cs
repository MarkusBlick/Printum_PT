using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintumProjektverwaltung.DAL;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Ausliefer06_Positionen : Form
    {
        public DAL.DataSet1.LieferungRow selectedRow;
        public DAL.DataSet1.ArtikelRow selectedArtikel;
        public DAL.DataSet1.LieferungPositionenRow selectedPosition;

        int aenderZeilenindex = 0;

        public Ausliefer06_Positionen()
        {
            InitializeComponent();
        }

        private void Ausliefer06_Positionen_Load(object sender, EventArgs e)
        {
            this.lieferungPositionenTableAdapter1.FillBy1(dataSet1.LieferungPositionen, selectedRow.AuftagID);
            this.artikelTableAdapter1.Fill(dataSet1.Artikel);
            if (selectedRow != null)
            {
                this.label1.Text += " " + selectedRow.AuftragNummer + " " + selectedRow.Bezeichnung;
            }

            GeaendertGeloeschtAnzeigen(false);

            this.lieferungPositionenDataGridView.Sort(lieferungPositionenDataGridView.Columns["dgvPositionNr"], ListSortDirection.Ascending);
        }

        private void GeaendertGeloeschtAnzeigen(bool v)
        {
            if (v)
            {
                this.lieferungPositionenBindingSource.Filter = "";

                this.lieferungPositionenDataGridView.Columns["GeaenderAm"].Visible = true;
                this.lieferungPositionenDataGridView.Columns["GeaendertVon"].Visible = true;
                this.lieferungPositionenDataGridView.Columns["GeaendertGrund"].Visible = true;
                this.lieferungPositionenDataGridView.Columns["GeloeschtAm"].Visible = true;
                this.lieferungPositionenDataGridView.Columns["GeloeschtVon"].Visible = true;
                this.lieferungPositionenDataGridView.Columns["GeloeschtGrund"].Visible = true;

                foreach (DataGridViewRow row in this.lieferungPositionenDataGridView.Rows)
                {
                    //  row.DefaultCellStyle.ForeColor = row.Cells["GeaenderAm"].Value != null ? Color.DarkSeaGreen : Color.Black;
                    //    //row.DefaultCellStyle.ForeColor = row.Cells["GeloeschtAm"].Value != null ? Color.Blue : Color.Black;



                    if (row.Cells["GeaenderAm"].Value != System.DBNull.Value || row.Cells["GeloeschtAm"].Value != System.DBNull.Value)
                    {
                        row.DefaultCellStyle.ForeColor = Color.DarkSeaGreen;
                        if (row.Cells["GeloeschtAm"].Value != System.DBNull.Value)
                        {
                            row.DefaultCellStyle.ForeColor = Color.MediumVioletRed;
                        }
                    }
                    //    else
                    //    {
                    //        if (row.Cells["GeaenderAm"] != null && row.Cells["GeaenderAm"].Value != null)
                    //        {
                    //            row.DefaultCellStyle.ForeColor = Color.Blue;
                    //        }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //    }
                }
            }
            else
            {
                this.lieferungPositionenBindingSource.Filter = "GeaenderAm Is Null";

                this.lieferungPositionenDataGridView.Columns["GeaenderAm"].Visible = false;
                this.lieferungPositionenDataGridView.Columns["GeaendertVon"].Visible = false;
                this.lieferungPositionenDataGridView.Columns["GeaendertGrund"].Visible = false;
                this.lieferungPositionenDataGridView.Columns["GeloeschtAm"].Visible = false;
                this.lieferungPositionenDataGridView.Columns["GeloeschtVon"].Visible = false;
                this.lieferungPositionenDataGridView.Columns["GeloeschtGrund"].Visible = false;

            }
        }

        private void button2_speichern_Click(object sender, EventArgs e)
        {


            // die geänderten Rows
            DataTable changedRecords = this.dataSet1.LieferungPositionen.GetChanges(DataRowState.Modified);



            if (changedRecords != null)
            {

                for (int i = 0; i < changedRecords.Rows.Count; i++)
                {
                    DataRow current = changedRecords.Rows[i];
                    try
                    {
                        var chaangedRow = (DAL.DataSet1.LieferungPositionenRow)current;
                        chaangedRow.GeaenderAm = DateTime.Now;
                        chaangedRow.GeaendertVon = Environment.UserName;

                        this.dataSet1.LieferungPositionen.AddLieferungPositionenRow(chaangedRow);
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }

                }

            }


            DataTable newRecords = this.dataSet1.LieferungPositionen.GetChanges(DataRowState.Modified);

            if (newRecords != null)
            {

                for (int i = 0; i < newRecords.Rows.Count; i++)
                {
                    DataRow current = newRecords.Rows[i];
                    try
                    {
                        var chaangedRow = (DAL.DataSet1.LieferungPositionenRow)current;
                        chaangedRow.HinzugefuegtAm = DateTime.Now;
                        chaangedRow.HinzugefuegtVon = Environment.UserName;

                        this.dataSet1.LieferungPositionen.AddLieferungPositionenRow(chaangedRow);
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }

                }

            }


            speichern();


        }

        private void speichern()
        {
            this.Validate();
            this.lieferungPositionenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void lieferungPositionenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var currentcell = lieferungPositionenDataGridView.CurrentCellAddress;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                if (senderGrid.Columns[e.ColumnIndex].Name == "ArtikelnrButton")
                {
                    ArtikelAuswaehlen(currentcell);

                }




                if (senderGrid.Columns[e.ColumnIndex].Name == "aendernButton")
                {
                    senderGrid.Columns["speichernButton"].Visible = true; ;
                    senderGrid.Columns["ArtikelnrButton"].Visible = true; ;
                    senderGrid.Columns["dgvArtikelnummer"].Visible = false; ;
                    senderGrid.Columns["aendernButton"].Visible = false; ;

                    aenderZeilenindex = e.RowIndex;
                    machRowSchreibbar(true, currentcell);

                }

                if (senderGrid.Columns[e.ColumnIndex].Name == "speichernButton")
                {
                    if (e.RowIndex != aenderZeilenindex)
                    {
                        MessageBox.Show("Hey," + Environment.NewLine
                            + " bist wohl in die falsche Zeile gerutscht.... " + Environment.NewLine + Environment.NewLine
                            + " hier wurde nichts gändert");
                    }
                    else
                    {


                        senderGrid.Columns["speichernButton"].Visible = false; ;
                        senderGrid.Columns["ArtikelnrButton"].Visible = false; ;
                        senderGrid.Columns["dgvArtikelnummer"].Visible = true; ;
                        senderGrid.Columns["aendernButton"].Visible = true; ;


                        zeileAendern(currentcell);
                        machRowSchreibbar(false, currentcell);

                    }
                }


                if (senderGrid.Columns[e.ColumnIndex].Name == "loeschenButton")
                {
                    zeileLöschen(currentcell);
                }
            }
        }

        private void zeileLöschen(Point currentcell)
        {

            var dieZeile = this.lieferungPositionenDataGridView.Rows[currentcell.Y];
            var drv = dieZeile.DataBoundItem as DataRowView;


            var row = drv.Row as DAL.DataSet1.LieferungPositionenRow;

            var dbrow = this.dataSet1.LieferungPositionen.FindByPositionenID(row.PositionenID);
            dbrow.AuftragID = selectedRow.AuftagID;
            dbrow.GeloeschtAm = DateTime.Now;
            dbrow.GeloeschtVon = Environment.UserName;
            dbrow.GeloeschtGrund = Helper.PromptDialog.ShowDialog("Bitte den Grund für das Löschen eingeben", "Grund angeben");

            speichern();

        }

        private void zeileAendern(Point currentcell)
        {
            var dieZeile = this.lieferungPositionenDataGridView.Rows[currentcell.Y];
            var drv = dieZeile.DataBoundItem as DataRowView;


            var row = drv.Row as DAL.DataSet1.LieferungPositionenRow;
            row.AuftragID = selectedRow.AuftagID;

            // alte Row speichern
            DAL.DataSet1.LieferungPositionenRow dbrow;

            var timspan = DateTime.Now - row.HinzugefuegtAm;

            if (row.IsHinzugefuegtAmNull() == false && timspan.Days > 1)
            {

                dbrow = getCloneFrom(row);

                dbrow.GeaenderAm = DateTime.Now;
                dbrow.GeaendertVon = Environment.UserName;
                dbrow.GeaendertGrund = Helper.PromptDialog.ShowDialog("Bitte den Grund der Änderung eingeben", "Grund angeben");
                this.dataSet1.LieferungPositionen.AddLieferungPositionenRow(dbrow);
            }



            speichern();


        }

        private void machRowSchreibbar(bool v, Point currentcell)
        {

            var dieZeile = this.lieferungPositionenDataGridView.Rows[currentcell.Y];

            if (v)
            {
                dieZeile.Cells["dgvPositionNr"].ReadOnly = false;
                dieZeile.Cells["dgvPreis"].ReadOnly = false;
            }
            else
            {
                dieZeile.Cells["dgvPositionNr"].ReadOnly = true;
                dieZeile.Cells["dgvPreis"].ReadOnly = true;
            }

        }

        private DataSet1.LieferungPositionenRow getCloneFrom(DataSet1.LieferungPositionenRow row)
        {
            var nr = this.dataSet1.LieferungPositionen.NewLieferungPositionenRow();
            if (!row.IsArtikeIDNull())
            {
                nr.ArtikeID = row.ArtikeID;

            }
            if (!row.IsArtikelnummerNull())
            {
                nr.Artikelnummer = row.Artikelnummer;
            }

            if (!row.IsBeschreibungNull())
            {
                nr.Beschreibung = row.Beschreibung;
            }
            if (!row.IsBeschreibungEnglishNull())
            {
                nr.BeschreibungEnglish = row.BeschreibungEnglish;
            }
            if (!row.IsEinheitNull())
            {
                nr.Einheit = row.Einheit;
            }
            if (!row.IsEinheitIDNull())
            {
                nr.EinheitID = row.EinheitID;
            }
            if (!row.IsHinzugefuegtAmNull())
            {
                nr.HinzugefuegtAm = row.HinzugefuegtAm;
            }
            if (!row.IsHinzugefuegtGrundNull())
            {
                nr.HinzugefuegtGrund = row.HinzugefuegtGrund;
            }
            if (!row.IsHinzugefuegtVonNull())
            {
                nr.HinzugefuegtVon = row.HinzugefuegtVon;

            }
            if (!row.IsPositionNrNull())
            {
                nr.PositionNr = row.PositionNr;
            }
            if (!row.IsPreisNull())
            {
                nr.Preis = row.Preis;
            }


            return nr;
        }

        private void ArtikelAuswaehlen(Point currentcell)
        {
            Ausliefer06_PositionenArtikel f6 = new Ausliefer06_PositionenArtikel();
            var q = f6.ShowDialog();

            if (selectedArtikel != null)
            {

                DataGridViewTextBoxCell cellArtikelID = (DataGridViewTextBoxCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["dgvArtikelID"];

                cellArtikelID.Value = selectedArtikel.ArtikelID;

                DataGridViewButtonCell cellArtikelButton = (DataGridViewButtonCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["ArtikelnrButton"];
                cellArtikelButton.Value = selectedArtikel.Artikelnummer;


                DataGridViewTextBoxCell cellBeschreibung = (DataGridViewTextBoxCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["dgvBeschreibung"];
                try
                {
                    cellBeschreibung.Value = selectedArtikel.Beschreibung;
                }
                catch (Exception) { }

                DataGridViewTextBoxCell cellBeschreibungEnglisch = (DataGridViewTextBoxCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["dgvBeschreibungEnglisch"];
                try
                {
                    cellBeschreibungEnglisch.Value = selectedArtikel.BeschreibungEnglish;
                }
                catch (Exception) { }

                DataGridViewTextBoxCell cellPreis = (DataGridViewTextBoxCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["dgvPreis"];
                try
                {
                    cellPreis.Value = selectedArtikel.Preis;
                }
                catch (Exception) { }


                DataGridViewTextBoxCell cellEinheit = (DataGridViewTextBoxCell)lieferungPositionenDataGridView.Rows[currentcell.Y].Cells["dgvEinheit"];
                try
                {
                    cellEinheit.Value = selectedArtikel.Einheit;
                }
                catch (Exception) { }


            }
        }

        // sortieren
        private void button1_Click(object sender, EventArgs e)
        {
            this.lieferungPositionenDataGridView.Sort(lieferungPositionenDataGridView.Columns["dgvPositionNr"], ListSortDirection.Ascending);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GeaendertGeloeschtAnzeigen(this.checkBox1.Checked);
        }


        private void button3_neu_Click(object sender, EventArgs e)
        {
            selectedPosition = this.dataSet1.LieferungPositionen.NewLieferungPositionenRow();

            Ausliefer06_PositionenNeu f6neu = new Ausliefer06_PositionenNeu();
            var ergebniss = f6neu.ShowDialog();

            if (ergebniss == DialogResult.OK)
            {
                selectedPosition.HinzugefuegtAm = DateTime.Now;
                selectedPosition.HinzugefuegtVon = Environment.UserName;
                selectedPosition.AuftragID = this.selectedRow.AuftagID;

                this.dataSet1.LieferungPositionen.AddLieferungPositionenRow(selectedPosition);

                speichern();
            }



        }
    }
}
