using System;
using System.Globalization;
using System.Windows.Forms;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Helper;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Rechnung01_main : Form
    {
        public bool duDarfst = false;
        public Rechnung01_main()
        {
            InitializeComponent();
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToLower();

            if (user.Contains("blick") ||
                user.Contains("sekretariat"))
            {
                duDarfst = true;
            }
        }

        private void priProLieferscheinRechnungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            priProRechnungBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);

        }

        private void Rechnung01_main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.PriProRechnung". Sie können sie bei Bedarf verschieben oder entfernen.
            priProRechnungTableAdapter.Fill(dataSet1.PriProRechnung);


        }

        private void button1_neueRechnung_Click(object sender, EventArgs e)
        {

            if (duDarfst)
            {
                Rechnung05_neueRE REneu = new Rechnung05_neueRE();
                REneu.ShowDialog();
                priProRechnungTableAdapter.Fill(dataSet1.PriProRechnung);
            }
            else
            {
                MessageBox.Show(" na, na, na" + Environment.NewLine + Environment.NewLine +
                    "das darf doch nur das Sekretariat!");
            }


        }



        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string filtertext = "LieferscheinNr LIKE '*" + textBox1_suchen.Text
                                                + "*' OR CONVERT(Projektnummer, 'System.String')  LIKE '*" + textBox1_suchen.Text
                                                + "*' OR RechnungBeschreibung LIKE '*" + textBox1_suchen.Text
                                                + "*' OR RechnungNr LIKE '*" + textBox1_suchen.Text
                                                + "*' OR RE_Firmenname LIKE '*" + textBox1_suchen.Text
                                                + "*'";

            priProRechnungBindingSource.Filter = filtertext;
        }


        private void button2_rechnung_Click(object sender, EventArgs e)
        {

            ////    this.label_speichern.Text = "Liefertermin laut AB und Preise können geändert werden";
            panel3.Visible = true;

            priProRechnungDataGridView.ReadOnly = false;

            priProRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = false;
            priProRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = false;
        }

        private void button_aenderungSpeichern_Click(object sender, EventArgs e)
        {
            Validate();
            priProRechnungBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
            panel3.Visible = false;

            priProRechnungDataGridView.ReadOnly = true;

            priProRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = true;
            priProRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = true;
        }



        private void priProRechnungDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).CurrentRow;
            var senderGrid = (DataGridView)sender;
            if (e != null)
            {
                var colmn = senderGrid.Columns[e.ColumnIndex];

                if (row != null && duDarfst)
                {
                    if (colmn.HeaderText == "PDF öffnen" || colmn.HeaderText == "Excel öffnen")
                    {


                        var pfad = row.Cells["RechnungPfad"].Value.ToString();
                        pfad = fileHelper.EntwicklungsPfadHelper(pfad);
                        if (System.IO.File.Exists(pfad))
                        {
                            System.Diagnostics.Process.Start(pfad);
                        }
                        else { MessageBox.Show("die Datei existiert nicht! " + Environment.NewLine + Environment.NewLine + pfad); }
                    }
                }
            }
        }


        private void priProRechnungDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            priProRechnungDataGridView_RowHeaderMouseClick(sender, null);
        }

        private void priProRechnungDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var colmn = senderGrid.Columns[e.ColumnIndex];

                var row = ((DataGridView)sender).CurrentRow;
                var pfad = row.Cells["RechnungPfad"].Value.ToString();
                pfad = fileHelper.EntwicklungsPfadHelper(pfad);

                if (row != null && duDarfst)
                {
                    if (colmn.HeaderText == "PDF öffnen" || colmn.HeaderText == "Excel öffnen")
                    {


                        if (colmn.HeaderText == "PDF öffnen")
                        {
                            pfad = pfad.Replace(".xlsx", ".pdf");
                        }



                        if (System.IO.File.Exists(pfad))
                        {
                            System.Diagnostics.Process.Start(pfad);
                        }

                        else { MessageBox.Show("die Datei existiert nicht! " + Environment.NewLine + Environment.NewLine + pfad); }

                    }



                    if (colmn.HeaderText == "Zahlungen")
                    {
                        //MessageBox.Show(row.Cells["PriProRechnungID"].Value.ToString());
                        Rechnung07_Zahlungen r7 = new Rechnung07_Zahlungen(row);
                        r7.ShowDialog();
                        priProRechnungTableAdapter.Fill(dataSet1.PriProRechnung);

                    }

                }
            }
        }

        private void priProRechnungDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var rBetrag = 0.0;
            var zBetrag = 0.0;
            foreach (DataGridViewRow row in this.priProRechnungDataGridView.Rows)
            {


                var value1 = row.Cells["Rechnungsbetrag"].Value;
                var value2 = row.Cells["Zahlungsbetrag"].Value;
                try
                {
                    if (value1 != null)
                    {
                        if (value1.GetType().Name != "DBNull")
                        {
                            rBetrag += (double)value1;

                        }
                    }
                    if (value2 != null)
                    {
                        if (value2.GetType().Name != "DBNull")
                        {
                            zBetrag += (double)value2;

                        }
                    }

                }
                catch (Exception ex)
                {

                    var bal = ex.ToString(); ;
                }
            }

            this.SummeRechnungsBetragTextBox.Text = rBetrag.ToString("C", CultureInfo.CreateSpecificCulture("de-DE"));
            this.zahlungsBetragTextbox.Text = zBetrag.ToString("C", CultureInfo.CreateSpecificCulture("de-DE"));
        }
    }
}
