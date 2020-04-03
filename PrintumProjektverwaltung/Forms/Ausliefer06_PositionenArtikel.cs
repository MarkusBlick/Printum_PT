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
    public partial class Ausliefer06_PositionenArtikel : Form
    {
        Ausliefer06_Positionen f6;

        public Ausliefer06_PositionenArtikel()
        {
            InitializeComponent();
        }



        private void Ausliefer06_PositionenArtikel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Artikel". Sie können sie bei Bedarf verschieben oder entfernen.
            this.artikelTableAdapter.Fill(this.dataSet1.Artikel);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.artikelBindingSource.Filter = "Artikelnummer LIKE '*" + this.textBox1.Text
                                                + "*' OR Beschreibung LIKE '*" + this.textBox1.Text + "*'";
        }


        private void uebernehmen()
        {



        }

        private void artikelDataGridView_DoubleClick(object sender, EventArgs e)
        {
            f6 = Application.OpenForms["Ausliefer06_Positionen"] as Ausliefer06_Positionen;

            var dgv = sender as DataGridView;
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
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
