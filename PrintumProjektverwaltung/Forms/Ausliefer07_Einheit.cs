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
    public partial class Ausliefer07_Einheit : Form
    {
        public Ausliefer07_Einheit()
        {
            InitializeComponent();
        }



        private void einheitBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.einheitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Ausliefer07_Einheit_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Einheit". Sie können sie bei Bedarf verschieben oder entfernen.
            this.einheitTableAdapter.Fill(this.dataSet1.Einheit);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            einheitBindingNavigatorSaveItem_Click_1(sender, e);
        }

        private void button1_neu_Click(object sender, EventArgs e)
        {
            this.einheitBindingSource.AddNew();

            this.einheitNummerTextBox.ReadOnly = false;
            this.einheitNummerTextBox.Text = getNextEinheitnummer();
            this.einheitNummerTextBox.Focus();


        }

        private string getNextEinheitnummer()
        {
            string letztes = dataSet1.Einheit.AsEnumerable()
                            .Max(row => row["EinheitNummer"])
                            .ToString();
            string a = letztes.Trim().Replace("E", "");
            string b = a.Replace("-", "");
            string c = b.Replace(" ", "");
            string d = c.Substring(0, 4);
            int zahl;
            if (Int32.TryParse(d, out zahl))
            {
                int neuezahl = zahl + 1;
                letztes = "E-" + neuezahl.ToString() + "00";
            }
            return letztes;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            this.einheitBindingSource.Filter = "EinheitNummer LIKE '*" + this.textBox1_suchen.Text + "*'"
                + " OR Beschreibung LIKE '*" + this.textBox1_suchen.Text + "*'";
        }
    }
}
