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
using Microsoft.Exchange.WebServices.Data;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Forms;
using PrintumProjektverwaltung.Helper;

namespace PrintumProjektverwaltung
{
    public partial class Rechnung05_neueRE : Form
    {

        public string Projektname;
        public int Projektnummer;
        public string Projektordnerpfad;


        public string LieferscheinNr;
        public string LieferscheinBeschreibung;
        public string LieferscheinAdresse;

        public DataSet1.AdressenRow Adressenrow { get; internal set; }
        //  public string RootOrdner { get; internal set; }

        private string rechnungordner;
        private string exceldateiname;

        DataSet1.PriProRechnungRow newrow;
        DataSet1.PriProLieferscheinRechnungRow lieferRechRow;

        public Rechnung05_neueRE()
        {
            InitializeComponent();
            Rechnung05_neueRE_Load();
        }



        private void priProLieferscheinRechnungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Rechnung05_neueRE_Load()
        {
            this.priProRechnungTableAdapter.Fill(this.dataSet1.PriProRechnung);

            this.priProRechnungBindingNavigator.BindingSource.AddNew();
            this.priProRechnungBindingNavigator.BindingSource.MoveLast();

            DataRowView etwas = (DataRowView)this.priProRechnungBindingSource.Current;

            newrow = (DataSet1.PriProRechnungRow)etwas.Row;



            newrow.RechnungErsteller = Environment.UserName;
            newrow.RechnungDatum = DateTime.Now;
            newrow.PriProRechnungID = this.GetNeueNummer();
            // newrow.RechnungNr = "RE-" + newrow.PriProRechnungID.ToString();
            newrow.RechnungNr = newrow.PriProRechnungID.ToString();

            this.rechnungNrTextBox.Text = newrow.RechnungNr;

            this.priProRechnungBindingSource.ResetBindings(false);



        }





        private int GetNeueNummer()
        {
            int Rid;
            string RechnungID = (DateTime.Now.Year).ToString() + "5000";
            Int32.TryParse(RechnungID, out Rid);

            var q = this.priProRechnungTableAdapter.ScalarQueryMaxID();
            if (q != null)
            {
                int liefer;
                if (Int32.TryParse(q.ToString(), out liefer))
                {
                    Rid = liefer + 1;
                }

                // die Jahreszahlumstellung
                string LidJahrString = Rid.ToString().Substring(0, 4);
                string aktuellesJahrString = (DateTime.Now.Year).ToString();
                if (LidJahrString.Equals(aktuellesJahrString) == false)
                {
                    string neuLid = (DateTime.Now.Year).ToString() + "0001";
                    Int32.TryParse(neuLid, out Rid);
                }
            }



            return Rid;
        }




        private void button1_Projekt_Click(object sender, EventArgs e)
        {
            Lieferschein02_Projekt L02 = new Lieferschein02_Projekt();
            DialogResult dr = L02.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Projektname = L02.rrrow.Projektname;
                this.Projektnummer = L02.rrrow.Projektnummer;
                this.Projektordnerpfad = L02.rrrow.RootOrdner;

                this.projektnummerTextBox.Text = this.Projektnummer.ToString();
                this.projektnameTextBox.Text = this.Projektname;
                this.rechnungPfadTextBox.Text = getLieferscheindateiPfad();
            }


        }


        private string getLieferscheindateiPfad()
        {
            ////"\\192.168.26.250\buchhaltung\R e c h n u n g e n\2018\11 November"
            //var pfad = @"\\192.168.26.250\PT-Rechnungen\";
            //\\192.168.26.250\PT-PriPro\20413 - Kurz Subtratwickler 350 4500816996
            var pfad = this.Projektordnerpfad == null ? "" : this.Projektordnerpfad.Trim() + @"\12 Rechnungen\";
            var jahr = DateTime.Now.Year.ToString();
            string monat = getCurrenMonthString();

            rechnungordner = pfad + jahr;
            CheckIfExists(rechnungordner);

            rechnungordner = pfad + jahr + monat;
            CheckIfExists(rechnungordner);

            exceldateiname = rechnungordner
                                //+ this.rechnungNrTextBox.Text.Trim().Substring(0,4) + " "
                                //+ this.rechnungNrTextBox.Text.Trim().Substring(3) + " "
                                + this.rechnungNrTextBox.Text + "-"
                                + this.rechnungBeschreibungTextBox.Text.Trim()
                                + ".xlsx";

            //if (this.rechnungBeschreibungTextBox.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bitte Beschreibung eingeben!" + Environment.NewLine + Environment.NewLine
            //                    + "Sonst ist der Dateiname nichts-sagend....");
            //}
            return exceldateiname;
        }

        private void CheckIfExists(string rechnungordner)
        {
            if (!Directory.Exists(rechnungordner))
            {
                Directory.CreateDirectory(rechnungordner);
            }
        }

        private string getCurrenMonthString()
        {

            switch (DateTime.Now.Month)
            {
                case 1:
                    return @"\01 Jannuar\";
                case 2:
                    return @"\02 Februar\";
                case 3:
                    return @"\03 März\";
                case 4:
                    return @"\04 April\";
                case 5:
                    return @"\05 Mai\";
                case 6:
                    return @"\06 Juni\";
                case 7:
                    return @"\07 Juli\";
                case 8:
                    return @"\08 August\";
                case 9:
                    return @"\09 September\";
                case 10:
                    return @"\10 Oktober\";
                case 11:
                    return @"\11 November\";
                default:
                    return @"\12 Dezember\";
            }
        }

        private void button2_adresse_Click(object sender, EventArgs e)
        {
            Form8_Adressen F08 = new Form8_Adressen();
            DialogResult dr = F08.ShowDialog();
            F08.button_Adresse5Rechnung.Visible = true;
            F08.button_Adresse4Lieferschein.Visible = false;
            if (dr == DialogResult.OK)
            {
                this.Adressenrow = F08.rrrow;
                AdresseEinschreiben();
            }


        }



        private void AdresseEinschreiben()
        {
            if (this.Adressenrow != null)
            {
                this.lS_FirmennameTextBox.Text = this.Adressenrow.Firmenname == null ? "" : this.Adressenrow.Firmenname;
                this.lS_LandTextEdit.Text = this.Adressenrow.Land == null ? "" : this.Adressenrow.Land;
                this.lS_NameTextBox.Text = this.Adressenrow.Name == null ? "" : this.Adressenrow.Name;
                this.lS_PLZTextBox.Text = this.Adressenrow.PLZ == null ? "" : this.Adressenrow.PLZ;
                this.lS_StadtTextBox.Text = this.Adressenrow.Ort == null ? "" : this.Adressenrow.Ort;
                this.lS_StrasseTextBox.Text = this.Adressenrow.Strasse == null ? "" : this.Adressenrow.Strasse;
            }
        }





        private void button4_REstandardErstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "Standard");
        }

        private void button5_DienstleistungErstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "Dienstleistung");
        }

        private void button6_AZ1Erstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ1");
        }

        private void button7_AZ2Erstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ2");
        }

        private void button8_AZ3Erstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ3");
        }

        private void button9_AZ4Erstellen_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ4");
        }


        private void SaveExcelClose(object sender, EventArgs e, string typ)
        {
            if (aufVollstaendigkeitChecken(sender, e))
            {
                this.Cursor = Cursors.WaitCursor;
                this.newrow.RechnungTyp = typ;

                priProLieferscheinRechnungBindingNavigatorSaveItem_Click(sender, e);

                ExcelHelperRechnung.CreateNewExcel(this.newrow, typ);

                this.Close();
            }


        }





        private bool aufVollstaendigkeitChecken(object sender, EventArgs e)
        {



            if (this.rechnungBeschreibungTextBox.Text == null || this.rechnungBeschreibungTextBox.Text.Length == 0)
            {
                this.rechnungBeschreibungTextBox.Focus();
                return false;
            }

            if (this.lS_FirmennameTextBox.Text == null || this.lS_FirmennameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte eine Adresse auswählen!");
                this.button2_adresse_Click(sender, e);
                return false;
            }


            if (this.projektnummerTextBox.Text == null || this.projektnummerTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte ein Projekt auswählen!");
                this.button1_Projekt_Click(sender, e);
                return false;
            }

            this.newrow.RechnungPfad = this.rechnungPfadTextBox.Text;
            this.newrow.Projektnummer = this.Projektnummer;
            this.newrow.Projektname = this.Projektname;
            this.newrow.RE_Name = this.lS_NameTextBox.Text;
            this.newrow.RE_PLZ = this.lS_PLZTextBox.Text;
            this.newrow.RE_Stadt = this.lS_StadtTextBox.Text;
            this.newrow.RE_Strasse = this.lS_StrasseTextBox.Text;

            return true;

        }

        private void button1_lieferschein_Click(object sender, EventArgs e)
        {
            Rechnung06_Lieferscheine R06 = new Rechnung06_Lieferscheine();
            DialogResult dr = R06.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.lieferRechRow = R06.rrrow;
                this.lieferscheinTextBox.Text = R06.rrrow.LieferscheinNr == null ? "" : R06.rrrow.LieferscheinNr;
            }

        }



        private void Rechnung05_neueRE_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.rechnungPfadTextBox.Text = getLieferscheindateiPfad();
            this.Cursor = Cursors.Default;
        }



        private void rechnungBeschreibungTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.rechnungBeschreibungTextBox.Text.Count() > 3)
            {
                this.rechnungPfadTextBox.Text = getLieferscheindateiPfad();
            }
        }

        private void button10_ENstandard_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "StandardEN");
        }

        private void button11_ENdienstleistung_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "DienstleistungEN");
        }

        private void button12_az1_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ1EN");
        }

        private void button13_az2_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ2EN");
        }

        private void button14_az3_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ3EN");
        }

        private void button15_az4_Click(object sender, EventArgs e)
        {
            SaveExcelClose(sender, e, "AZ4EN");
        }
    }
}
