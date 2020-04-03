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
    public partial class Lieferschein01_main : Form
    {
        public Lieferschein01_main()
        {
            InitializeComponent();
        }

        private void priProLieferscheinRechnungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProLieferscheinRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Lieferschein01_main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.PriProLieferscheinRechnung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.priProLieferscheinRechnungTableAdapter.Fill(this.dataSet1.PriProLieferscheinRechnung);

        }

        private void button1_neuerLieferschein_Click(object sender, EventArgs e)
        {
            Lieferschein05_neuerLS LSneu = new Lieferschein05_neuerLS();
            LSneu.ShowDialog();
            this.priProLieferscheinRechnungTableAdapter.Fill(this.dataSet1.PriProLieferscheinRechnung);

        }

        private void priProLieferscheinRechnungDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = ((DataGridView)sender).CurrentRow;
            if (row != null)
            {
                var pfad = row.Cells["LieferscheinPfad"].Value.ToString();
                pfad = fileHelper.EntwicklungsPfadHelper(pfad);
                if (System.IO.File.Exists(pfad))
                {
                    System.Diagnostics.Process.Start(pfad);
                }
                else { MessageBox.Show("die Datei existiert nicht! " + Environment.NewLine + Environment.NewLine + pfad); }
            }
        }


        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string filtertext = "LieferscheinNr LIKE '*" + this.textBox1_suchen.Text
                                                + "*' OR CONVERT(Projektnummer, 'System.String')  LIKE '*" + this.textBox1_suchen.Text 
                                                + "*' OR LieferscheinBeschreibung LIKE '*" + this.textBox1_suchen.Text 
                                                + "*' OR LS_Firmenname LIKE '*" + this.textBox1_suchen.Text
                                                + "*'";

            this.priProLieferscheinRechnungBindingSource.Filter = filtertext;
        }


        private void button2_rechnung_Click(object sender, EventArgs e)
        {

            ////    this.label_speichern.Text = "Liefertermin laut AB und Preise können geändert werden";
            this.panel3.Visible = true;

            this.priProLieferscheinRechnungDataGridView.ReadOnly = false;

            this.priProLieferscheinRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = false;
            this.priProLieferscheinRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = false;
        }

        private void button_aenderungSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProLieferscheinRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.panel3.Visible = false;

            this.priProLieferscheinRechnungDataGridView.ReadOnly = true;

            this.priProLieferscheinRechnungDataGridView.Columns["RechnungsNr"].ReadOnly = true;
            this.priProLieferscheinRechnungDataGridView.Columns["RechnungDatum"].ReadOnly = true;
        }


    }
}
