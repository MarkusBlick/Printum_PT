using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Ausliefer05_aendern : Form
    {
        public DAL.DataSet1.AdressenRow currAdress;
        public DAL.DataSet1.LieferungRow neueRow;
        public DAL.DataSet1.LieferungRow selectedRow;
        public DAL.DataSet1.ProjekteRow projektRow;

        public Ausliefer05_aendern()
        {
            InitializeComponent();
        }



        private void Ausliefer02_neu_Load(object sender, EventArgs e)
        {
            this.lieferungTableAdapter.Fill(dataSet1.Lieferung);
            neueRow = this.dataSet1.Lieferung.Where(x => x.AuftagID == selectedRow.AuftagID).First();

            if (neueRow != null)
            {
                auftragNummerTextBox.Text = neueRow.AuftragNummer;
                bezeichnungTextBox.Text = neueRow.Bezeichnung == null ? "" : neueRow.Bezeichnung;

                projektnummerTextBox.Text = neueRow.Projektnummer.ToString();
                projektnameTextBox.Text = neueRow.Projektname == null ? "" : neueRow.Projektname;

                adressLieferNameTextBox.Text = neueRow.AdressLieferName == null ? "" : neueRow.AdressLieferName;
                adressLieferStrasseTextBox.Text = neueRow.AdressLieferStrasse == null ? "" : neueRow.AdressLieferStrasse;
                adressLieferPLZTextBox.Text = neueRow.AdressLieferPLZ == null ? "" : neueRow.AdressLieferPLZ;
                adressLieferOrtTextBox.Text = neueRow.AdressLieferOrt == null ? "" : neueRow.AdressLieferOrt;
                adressLieferLandTextBox.Text = neueRow.AdressLieferLand == null ? "" : neueRow.AdressLieferLand;

                adressRechnungNameTextBox.Text = neueRow.AdressRechnungName == null ? "" : neueRow.AdressRechnungName;
                adressRechnungStrasseTextBox.Text = neueRow.AdressRechnungStrasse == null ? "" : neueRow.AdressRechnungStrasse;
                adressRechnungPLZTextBox.Text = neueRow.AdressRechnungPLZ == null ? "" : neueRow.AdressRechnungPLZ;
                adressRechnungLandTextBox.Text = neueRow.AdressRechnungLand == null ? "" : neueRow.AdressRechnungLand;
                adressRechnungOrtTextBox.Text = neueRow.AdressRechnungOrt == null ? "" : neueRow.AdressRechnungOrt;

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button_adresse_Click(object sender, EventArgs e)
        {
            Ausliefer03_AdressenSelect a03 = new Ausliefer03_AdressenSelect();
            a03.ShowDialog();

            if (currAdress != null)
            {
                this.adressLieferNameTextBox.Text = currAdress.Firmenname;
                this.adressLieferStrasseTextBox.Text = currAdress.Strasse;
                this.adressLieferPLZTextBox.Text = currAdress.PLZ;
                this.adressLieferOrtTextBox.Text = currAdress.Ort;
                this.adressLieferLandTextBox.Text = currAdress.Land;

                this.adressRechnungNameTextBox.Text = currAdress.Firmenname;
                this.adressRechnungStrasseTextBox.Text = currAdress.Strasse;
                this.adressRechnungPLZTextBox.Text = currAdress.PLZ;
                this.adressRechnungOrtTextBox.Text = currAdress.Ort;
                this.adressRechnungLandTextBox.Text = currAdress.Land;
            }
        }

        private int GetNewLieferID()
        {
            int neueID;

            // für das erste Mal
            if (this.dataSet1.Lieferung.Count == 0)
            {
                var jahrundtext = DateTime.Now.Year.ToString() + "0001";
                bool geklappt = Int32.TryParse(jahrundtext, out neueID);
            }
            else
            {
                int dashoechste =
                          (from p in dataSet1.Lieferung

                           select p.AuftagID).Max();


                string strHoechste = dashoechste.ToString();
                string dasJahrstr = strHoechste.Substring(0, strHoechste.Length - 4);
                int dasJahr = -1;
                bool geklappt = Int32.TryParse(dasJahrstr, out dasJahr);

                if (DateTime.Now.Year > dasJahr)
                {
                    var jahrundtext = DateTime.Now.Year.ToString() + "0001";
                    bool wiedergeklappt = Int32.TryParse(jahrundtext, out neueID);
                }
                else
                {
                    neueID = dashoechste + 1;
                }
            }


            return neueID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_ProjektWaehlen_Click(object sender, EventArgs e)
        {
            Ausliefer04_ProjektSelect A04 = new Ausliefer04_ProjektSelect();
            A04.ShowDialog();

            if (projektRow != null)
            {


                this.projektnameTextBox.Text = projektRow.Projektname;
                this.projektnummerTextBox.Text = projektRow.Projektnummer.ToString();
            }
        }

        private void button3_speichern_Click(object sender, EventArgs e)
        {

            neueRow.Bezeichnung = bezeichnungTextBox.Text;

            neueRow.Projektname = projektnameTextBox.Text;
            int neueProjektnummer;
            if (Int32.TryParse(projektnummerTextBox.Text, out neueProjektnummer))
            {
                neueRow.Projektnummer = neueProjektnummer;
            }


            neueRow.AdressLieferName = adressLieferNameTextBox.Text;
            neueRow.AdressLieferStrasse = adressLieferStrasseTextBox.Text;
            neueRow.AdressLieferPLZ = adressLieferPLZTextBox.Text;
            neueRow.AdressLieferOrt = adressLieferOrtTextBox.Text;
            neueRow.AdressLieferLand = adressLieferLandTextBox.Text;

            neueRow.AdressRechnungName = adressRechnungNameTextBox.Text;
            neueRow.AdressRechnungStrasse = adressRechnungStrasseTextBox.Text;
            neueRow.AdressRechnungPLZ = adressRechnungPLZTextBox.Text;
            neueRow.AdressRechnungLand = adressRechnungLandTextBox.Text;
            neueRow.AdressRechnungOrt = adressRechnungOrtTextBox.Text;

            this.lieferungTableAdapter.Update(this.dataSet1);

            this.Close();
        }
    }
}
