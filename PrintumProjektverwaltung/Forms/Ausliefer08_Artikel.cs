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
    public partial class Ausliefer08_Artikel : Form
    {
        public Ausliefer08_Artikel()
        {
            InitializeComponent();
        }

        private void Ausliefer08_Artikel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Artikel". Sie können sie bei Bedarf verschieben oder entfernen.
            this.artikelTableAdapter.Fill(this.dataSet1.Artikel);

        }

        private void button1_neu_Click(object sender, EventArgs e)
        {
            this.artikelBindingSource.AddNew();

            string letztes = dataSet1.Artikel.AsEnumerable()
                         .Max(row => row["Artikelnummer"])
                         .ToString();
            string a = letztes.Trim().Replace("A", "");
            string b = a.Replace("-", "");
            string c = b.Replace(" ", "");
            string d = c.Substring(0, 4);
            int zahl;
            if (Int32.TryParse(d, out zahl))
            {
                int neuezahl = zahl + 1;
                this.artikelnummerTextBox.Text = "A" + neuezahl.ToString() + "00";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artikelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.artikelBindingSource.Filter = "Artikelnummer LIKE '*" + this.textBox1.Text + "*'"
                + " OR Beschreibung LIKE '*" + this.textBox1.Text + "*'";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_neuAusAlt_Click(object sender, EventArgs e)
        {
            if (this.artikelnummerTextBox.Text.Count() > 0)
            {

                string artikelnr = this.artikelnummerTextBox.Text;
                string beschreibEnglisch = this.beschreibungEnglishTextBox.Text;
                string bezeichnugn = this.beschreibungTextBox.Text;
                string preis = this.preisTextBox.Text;
                string einheit = this.einheitTextBox.Text;
                var istbaugruppe = this.istBaugruppeCheckEdit.CheckState;

                this.artikelBindingSource.AddNew();

                this.artikelnummerTextBox.Text = getNextNr(artikelnr);
                this.beschreibungEnglishTextBox.Text = beschreibEnglisch;
                this.beschreibungTextBox.Text = bezeichnugn;
                this.preisTextBox.Text = preis;
                this.einheitTextBox.Text = einheit;
                this.istBaugruppeCheckEdit.CheckState = istbaugruppe;
            }
        }

        private string getNextNr(string artikelnr)
        {
            string neue = artikelnr;

            string a = artikelnr.Trim().Replace("A", "");
            string b = a.Replace("-", "");
            string c = b.Replace(" ", "");
            int zahl;
            if (Int32.TryParse(c, out zahl))
            {
                int neuezahl = zahl + 1;
                neue = "A" + neuezahl.ToString();
            } 

            return neue;
        }
    }
}
