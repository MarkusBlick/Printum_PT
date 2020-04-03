using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.Validate();
            this.priProRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Rechnung01_main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.PriProRechnung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.priProRechnungTableAdapter.Fill(this.dataSet1.PriProRechnung);


        }

        private void button1_neueRechnung_Click(object sender, EventArgs e)
        {

            if (duDarfst)
            {
                Rechnung05_neueRE REneu = new Rechnung05_neueRE();
                REneu.ShowDialog();
                this.priProRechnungTableAdapter.Fill(this.dataSet1.PriProRechnung);
            }
            else
            {
                MessageBox.Show(" na, na, na" + Environment.NewLine + Environment.NewLine +
                    "das darf doch nur das Sekretariat!");
            }


        }



        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string filtertext = "LieferscheinNr LIKE '*" + this.textBox1_suchen.Text
                                                + "*' OR CONVERT(Projektnummer, 'System.String')  LIKE '*" + this.textBox1_suchen.Text
                                                + "*' OR RechnungBeschreibung LIKE '*" + this.textBox1_suchen.Text
                                                + "*' OR RechnungNr LIKE '*" + this.textBox1_suchen.Text
                                                + "*' OR RE_Firmenname LIKE '*" + this.textBox1_suchen.Text
                                                + "*'";

            this.priProRechnungBindingSource.Filter = filtertext;
        }


        private void button2_rechnung_Click(object sender, EventArgs e)
        {

            ////    this.label_speichern.Text = "Liefertermin laut AB und Preise können geändert werden";
            this.panel3.Visible = true;

            this.priProRechnungDataGridView.ReadOnly = false;

            this.priProRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = false;
            this.priProRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = false;
        }

        private void button_aenderungSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.panel3.Visible = false;

            this.priProRechnungDataGridView.ReadOnly = true;

            this.priProRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = true;
            this.priProRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = true;
        }



        private void priProRechnungDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).CurrentRow;
            if (row != null && duDarfst)
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


        private void priProRechnungDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.priProRechnungDataGridView_RowHeaderMouseClick(sender, null);
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
            }
        }
    }
}
