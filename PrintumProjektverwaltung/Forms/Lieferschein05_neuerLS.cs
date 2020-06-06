using System;
using System.Data;
using System.Windows.Forms;
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
            Validate();
            priProLieferscheinRechnungBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);

        }

        private void Lieferschein05_neuerLS_Load(object sender, EventArgs e)
        {
            priProLieferscheinRechnungTableAdapter.Fill(dataSet1.PriProLieferscheinRechnung);

            priProLieferscheinRechnungBindingNavigator.BindingSource.AddNew();
            priProLieferscheinRechnungBindingNavigator.BindingSource.MoveLast();

            DataRowView etwas = (DataRowView)priProLieferscheinRechnungBindingSource.Current;

            newrow = (DataSet1.PriProLieferscheinRechnungRow)etwas.Row;//  dataSet1.PriProLieferscheinRechnung.NewPriProLieferscheinRechnungRow();


            //this.lieferscheinErstellerTextEdit.Text = Environment.UserName;
            //this.lieferscheinDatumTextBox.Text = DateTime.Now.ToLongDateString();


            //this.priProLieferscheinRechnungIDTextBox.Text = this.GetNeueNummer().ToString();
            //this.lieferscheinNrTextBox.Text = "LS-" + this.priProLieferscheinRechnungIDTextBox.Text;


            newrow.LieferscheinErsteller = Environment.UserName;
            newrow.LieferscheinDatum = DateTime.Now;
            newrow.PriProLieferscheinRechnungID = GetNeueNummer();
            newrow.LieferscheinNr = "LS-" + newrow.PriProLieferscheinRechnungID.ToString();


            priProLieferscheinRechnungBindingSource.ResetBindings(false);

        }


        private int GetNeueNummer()
        {
            int Lid;
            string LieferscheinID = (DateTime.Now.Year - 2000).ToString() + "0500";
            Int32.TryParse(LieferscheinID, out Lid);

            var q = priProLieferscheinRechnungTableAdapter.ScalarQueryMaxID();
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
                Projektname = L02.rrrow.Projektname;
                Projektnummer = L02.rrrow.Projektnummer;
                RootOrdner = L02.rrrow.RootOrdner.Trim();

                projektnummerTextBox.Text = Projektnummer.ToString();
                projektnameTextBox.Text = Projektname;
                lieferscheinPfadTextBox.Text = getLieferscheindateiPfad();

            }

            //L02.ShowDialog();
            //this.projektnummerTextBox.Text = this.Projektnummer.ToString();
            //this.projektnameTextBox.Text = this.Projektname;
            //this.lieferscheinPfadTextBox.Text = getLieferscheindateiPfad();

        }


        private string getLieferscheindateiPfad()
        {
            var pfad = RootOrdner == null ? "" : RootOrdner.Trim() + @"\05 Lieferscheine PriPro\";
            lieferordner = pfad;
            if (RootOrdner != null && RootOrdner.Contains("192.168.26.250"))
            {
                pfad = pfad.Replace("PRINTUMSERVER", "192.168.26.250");
            }
            lieferordner = pfad;
            exceldateiname = pfad
                                + lieferscheinNrTextBox.Text + "-"
                                + lieferscheinBeschreibungTextBox.Text.Trim()
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
                Adressenrow = F08.rrrow;
                AdresseEinschreiben();
            }

        }



        private void AdresseEinschreiben()
        {
            lS_FirmennameTextBox.Text = Adressenrow.Firmenname == null ? "" : Adressenrow.Firmenname;
            lS_LandTextEdit.Text = Adressenrow.Land == null ? "" : Adressenrow.Land;
            lS_NameTextBox.Text = Adressenrow.Name == null ? "" : Adressenrow.Name;
            lS_PLZTextBox.Text = Adressenrow.PLZ == null ? "" : Adressenrow.PLZ;
            lS_StadtTextBox.Text = Adressenrow.Ort == null ? "" : Adressenrow.Ort;
            lS_StrasseTextBox.Text = Adressenrow.Strasse == null ? "" : Adressenrow.Strasse;
        }

        private void button3_LsErstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);


            ExcelHelperLieferschein.createNewExcel(newrow, "Unterschrift");
        }


        private void button4_LsblankoErstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(newrow, "blanko");

        }


        private void button4_LKWerstellen_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(newrow, "LKW");

        }


        private void aufVollstaendigkeitChecken(object sender, EventArgs e)
        {


            if (lieferscheinBeschreibungTextBox.Text == null || lieferscheinBeschreibungTextBox.Text.Length == 0)
            {
                MessageBox.Show("Der Lieferschein braucht eine Beschreibung");
                lieferscheinBeschreibungTextBox.Focus();
                return;
            }

            if (lS_FirmennameTextBox.Text == null || lS_FirmennameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte eine Adresse auswählen!");
                button2_adresse_Click(sender, e);
                return;
            }


            if (projektnummerTextBox.Text == null || projektnummerTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte ein Projekt auswählen!");
                button1_Projekt_Click(sender, e);
                return;
            }

            priProLieferscheinRechnungBindingNavigatorSaveItem_Click(sender, e);

        }

        private void button4_DeliveryNoteBlanko_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(newrow, "blankoEN");

        }

        private void button5_DeliveryNoteEmpfang_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);


            ExcelHelperLieferschein.createNewExcel(newrow, "UnterschriftEN");
        }

        private void button6_DeliveryNoteLKW_Click(object sender, EventArgs e)
        {
            aufVollstaendigkeitChecken(sender, e);

            ExcelHelperLieferschein.createNewExcel(newrow, "LKWEN");

        }
    }
}
