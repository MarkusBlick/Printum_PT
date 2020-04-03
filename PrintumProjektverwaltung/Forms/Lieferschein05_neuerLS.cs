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
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Forms;
using PrintumProjektverwaltung.Helper;

namespace PrintumProjektverwaltung
{
    public partial class Lieferschein05_neuerLS : Form
    {

        public string Projektname;
        public int Projektnummer;

        public DataSet1.AdressenRow Adressenrow { get; internal set; }
        public string RootOrdner { get; internal set; }

        private string lieferordner;
        private string exceldateiname;

        DataSet1.PriProLieferscheinRechnungRow newrow;

        public Lieferschein05_neuerLS()
        {
            InitializeComponent();
        }

        private void priProLieferscheinRechnungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProLieferscheinRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Lieferschein05_neuerLS_Load(object sender, EventArgs e)
        {
            this.priProLieferscheinRechnungTableAdapter.Fill(this.dataSet1.PriProLieferscheinRechnung);

            this.priProLieferscheinRechnungBindingNavigator.BindingSource.AddNew();
            this.priProLieferscheinRechnungBindingNavigator.BindingSource.MoveLast();

            DataRowView etwas = (DataRowView)this.priProLieferscheinRechnungBindingSource.Current;

            newrow = (DataSet1.PriProLieferscheinRechnungRow)etwas.Row;//  dataSet1.PriProLieferscheinRechnung.NewPriProLieferscheinRechnungRow();


            //this.lieferscheinErstellerTextEdit.Text = Environment.UserName;
            //this.lieferscheinDatumTextBox.Text = DateTime.Now.ToLongDateString();


            //this.priProLieferscheinRechnungIDTextBox.Text = this.GetNeueNummer().ToString();
            //this.lieferscheinNrTextBox.Text = "LS-" + this.priProLieferscheinRechnungIDTextBox.Text;


            newrow.LieferscheinErsteller = Environment.UserName;
            newrow.LieferscheinDatum = DateTime.Now;
            newrow.PriProLieferscheinRechnungID = this.GetNeueNummer();
            newrow.LieferscheinNr = "LS-" + newrow.PriProLieferscheinRechnungID.ToString();


            this.priProLieferscheinRechnungBindingSource.ResetBindings(false);

        }


        private int GetNeueNummer()
        {
            int Lid;
            string LieferscheinID = (DateTime.Now.Year - 2000).ToString() + "0500";
            Int32.TryParse(LieferscheinID, out Lid);

            var q = this.priProLieferscheinRechnungTableAdapter.ScalarQueryMaxID();
            if (q != null)
            {
                int liefer;
                if (Int32.TryParse(q.ToString(), out liefer))
                {
                    Lid = liefer + 1;
                }

                // die Jahreszahlumstellung
                string LidJahrString = Lid.ToString().Substring(0, 2);
                string aktuellesJahrString = (DateTime.Now.Year - 2000).ToString();
                if (LidJahrString.Equals(aktuellesJahrString) == false)
                {
                    string neuLid = (DateTime.Now.Year - 2000).ToString() + "0000";
                    Int32.TryParse(neuLid, out Lid);
                }
            }



            return Lid;
        }




        private void button1_Projekt_Click(object sender, EventArgs e)
        {
            Lieferschein02_Projekt L02 = new Lieferschein02_Projekt();
            DialogResult dr = L02.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Projektname = L02.rrrow.Projektname;
                this.Projektnummer = L02.rrrow.Projektnummer;
                this.RootOrdner = L02.rrrow.RootOrdner;

                this.projektnummerTextBox.Text = this.Projektnummer.ToString();
                this.projektnameTextBox.Text = this.Projektname;
                this.lieferscheinPfadTextBox.Text = getLieferscheindateiPfad();

            }

            //L02.ShowDialog();
            //this.projektnummerTextBox.Text = this.Projektnummer.ToString();
            //this.projektnameTextBox.Text = this.Projektname;
            //this.lieferscheinPfadTextBox.Text = getLieferscheindateiPfad();

        }


        private string getLieferscheindateiPfad()
        {
            var pfad = this.RootOrdner + @"\05 Lieferscheine PriPro\";
            lieferordner = pfad;
            if (this.RootOrdner != null && this.RootOrdner.Contains("192.168.26.250"))
            {
                pfad = pfad.Replace("PRINTUMSERVER", "192.168.26.250");
            }
            lieferordner = pfad;
            exceldateiname = pfad
                                + this.lieferscheinNrTextBox.Text + "-"
                                + this.lieferscheinBeschreibungTextBox.Text.Trim()
                                + ".xlsx";
            return exceldateiname;
        }




        private void button2_adresse_Click(object sender, EventArgs e)
        {
            Form8_Adressen F08 = new Form8_Adressen();
            F08.button_Adresse4Lieferschein.Visible = true;
            DialogResult dr = F08.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Adressenrow = F08.rrrow;
                AdresseEinschreiben();
            }

        }



        private void AdresseEinschreiben()
        {
            this.lS_FirmennameTextBox.Text = this.Adressenrow.Firmenname == null ? "" : this.Adressenrow.Firmenname;
            this.lS_LandTextEdit.Text = this.Adressenrow.Land == null ? "" : this.Adressenrow.Land;
            this.lS_NameTextBox.Text = this.Adressenrow.Name == null ? "" : this.Adressenrow.Name;
            this.lS_PLZTextBox.Text = this.Adressenrow.PLZ == null ? "" : this.Adressenrow.PLZ;
            this.lS_StadtTextBox.Text = this.Adressenrow.Ort == null ? "" : this.Adressenrow.Ort;
            this.lS_StrasseTextBox.Text = this.Adressenrow.Strasse == null ? "" : this.Adressenrow.Strasse;
        }

        private void button3_LsErstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);


            ExcelHelperLieferschein.createNewExcel(this.newrow, "Unterschrift");
        }


        private void button4_LsblankoErstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(this.newrow, "blanko");

        }


        private void button4_LKWerstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(this.newrow, "LKW");

        }


        private void aufVollstaendigkeitChecken(object sender, EventArgs e)
        {


            if (this.lieferscheinBeschreibungTextBox.Text == null || this.lieferscheinBeschreibungTextBox.Text.Length == 0)
            {
                MessageBox.Show("Der Lieferschein braucht eine Beschreibung");
                this.lieferscheinBeschreibungTextBox.Focus();
                return;
            }

            if (this.lS_FirmennameTextBox.Text == null || this.lS_FirmennameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte eine Adresse auswählen!");
                this.button2_adresse_Click(sender, e);
                return;
            }


            if (this.projektnummerTextBox.Text == null || this.projektnummerTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte ein Projekt auswählen!");
                this.button1_Projekt_Click(sender, e);
                return;
            }

            priProLieferscheinRechnungBindingNavigatorSaveItem_Click(sender, e);

        }


    }
}
