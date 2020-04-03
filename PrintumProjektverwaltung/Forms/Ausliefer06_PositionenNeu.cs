using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Ausliefer06_PositionenNeu : Form
    {
        public Ausliefer06_PositionenNeu()
        {
            InitializeComponent();
        }

        private void Ausliefer06_PositionenNeu_Load(object sender, EventArgs e)
        {

            this.artikelTableAdapter1.Fill(this.dataSet11.Artikel);
            this.artikelDataGridView.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.artikelBindingSource.Filter = "Artikelnummer LIKE '*" + this.textBox2.Text
                                                + "*' OR Beschreibung LIKE '*" + this.textBox2.Text + "*'";
        }

        private void artikelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.artikelDataGridView.SelectedRows.Count == 1)
            {
                this.button1_speichern.Enabled = true;
            }
            else
            {
                this.button1_speichern.Enabled = false;
            }
        }

        private void button1_speichern_Click(object sender, EventArgs e)
        {

            Ausliefer06_Positionen f6 = Application.OpenForms["Ausliefer06_Positionen"] as Ausliefer06_Positionen;

            var dgv = this.artikelDataGridView;
            if (dgv != null)
            {
                var bs = dgv.DataSource as BindingSource;
                if (bs != null)
                {
                    var curr = bs.Current as DataRowView;
                    if (curr != null)
                    {
                        var row = curr.Row as DAL.DataSet1.ArtikelRow;
                        if (row != null)
                        {
                            f6.selectedArtikel = row;

                            f6.selectedPosition.ArtikeID = row.ArtikelID;
                            f6.selectedPosition.Artikelnummer = row.IsArtikelnummerNull() ? null : row.Artikelnummer;
                            f6.selectedPosition.Beschreibung = row.IsBeschreibungNull() ? null : row.Beschreibung;
                            f6.selectedPosition.BeschreibungEnglish = row.IsBeschreibungEnglishNull() ? null : row.BeschreibungEnglish;
                            f6.selectedPosition.Einheit = row.IsEinheitNull() ? null : row.Einheit;
                            f6.selectedPosition.Preis = row.IsPreisNull() ? new decimal(0) : row.Preis;
                            f6.selectedPosition.Mengeneinheit = row.IsMengeneinheitNull() ? null : row.Mengeneinheit;


                            int pos = 0;
                            Int32.TryParse(this.textBox1.Text, out pos);
                            f6.selectedPosition.PositionNr = pos;

                            int anzahl = 1;
                            Int32.TryParse(this.textBox3_anzahl.Text, out anzahl);
                            f6.selectedPosition.Anzahl = anzahl;



                            this.DialogResult = DialogResult.OK;

                        }
                    }
                }
            }
            this.Close();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_artikel_Click(object sender, EventArgs e)
        {
            this.artikelDataGridView.Visible = true;
            this.textBox2.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
