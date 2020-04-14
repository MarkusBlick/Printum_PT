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
    public partial class Form8_Adressen : Form
    {
        public List<Contact> alleAdressen;
        private Contact currContact;
        public string currUniqueID;
        public DAL.DataSet1.AdressenRow rrrow;

        public Form8_Adressen()
        {
            InitializeComponent();
        }



        private void Form8_Adressen_Load(object sender, EventArgs e)
        {
            this.alleAdressen = (Application.OpenForms["Form1_main"] as Form1_main).alleAdressen;
            //  die Outlookadressen werden auseglesen  
            dieInfoAdressenAuslesen();

            //  this.adressenDataGridView.ClearSelection();

        }


        private void dieInfoAdressenAuslesen()
        {
            this.dataSet1.Adressen.Clear();

            foreach (var adr in this.alleAdressen)
            {
                DAL.DataSet1.AdressenRow row = this.dataSet1.Adressen.NewAdressenRow();


                try
                {
                    string nachname = (adr.Surname == null) ? "" : adr.Surname;
                    row.Nachname = nachname;
                    string vorname = (adr.GivenName == null) ? "" : adr.GivenName;
                    row.Vorname = vorname;

                    if (adr.Categories.Count > 0)
                    {
                        string categories = "";

                        foreach (var item in adr.Categories)
                        {
                            categories += item + " ";
                        }
                        row.Categories = categories;
                    }


                    row.Name = (vorname.Count() > 0) ? vorname + " " + nachname : nachname;

                    row.Firmenname = (adr.CompanyName == null) ? "" : adr.CompanyName;


                    row.businessHomePage = (adr.BusinessHomePage == null) ? "" : adr.BusinessHomePage;
                    row.FileAs = (adr.FileAs == null) ? "" : adr.FileAs;
                    row.ID = adr.Id.UniqueId;
                    row.JobTitle = (adr.JobTitle == null) ? "" : adr.JobTitle;

                    if (adr.DisplayName != null)
                    {
                        adr.DisplayName = (adr.GivenName == null) ? "" : adr.GivenName + " ";
                        adr.DisplayName += (adr.Surname == null) ? "" : adr.Surname;
                    }


                    row.Matchcode = row.Firmenname + ", " + "(" + row.Name + "), ";

                    PhysicalAddressEntry entry;
                    PhysicalAddressKey key = PhysicalAddressKey.Business;
                    if (adr.PhysicalAddresses.TryGetValue(key, out entry))
                    {
                        row.Strasse = (entry.Street == null) ? "" : entry.Street;
                        row.Ort = (entry.City == null) ? "" : entry.City;
                        row.PLZ = (entry.PostalCode == null) ? "" : entry.PostalCode;
                        row.Land = (entry.CountryOrRegion == null) ? "" : entry.CountryOrRegion;
                        row.PLZundORT = row.PLZ + " " + row.Ort;

                        row.Matchcode += row.PLZundORT;
                    }



                    EmailAddress eAdress1;
                    EmailAddressKey eKey1 = EmailAddressKey.EmailAddress1;
                    if (adr.EmailAddresses.TryGetValue(eKey1, out eAdress1))
                    {
                        row.Email1Adresse = eAdress1.Address;
                    }
                    else
                    {
                        row.Email1Adresse = "";
                    }

                    EmailAddress eAdress2;
                    EmailAddressKey eKey2 = EmailAddressKey.EmailAddress2;
                    if (adr.EmailAddresses.TryGetValue(eKey2, out eAdress2))
                    {
                        row.Email2Adresse = eAdress2.Address;
                    }
                    else
                    {
                        row.Email2Adresse = "";
                    }

                    string buissnessNr = "";
                    PhoneNumberKey pKey = PhoneNumberKey.BusinessPhone;
                    if (adr.PhoneNumbers.TryGetValue(pKey, out buissnessNr))
                    {
                        row.Telefon1 = buissnessNr;
                    }
                    else
                    {
                        row.Telefon1 = "";
                    }

                    string mobileNR = "";
                    PhoneNumberKey mKey = PhoneNumberKey.MobilePhone;
                    if (adr.PhoneNumbers.TryGetValue(mKey, out mobileNR))
                    {
                        row.TelefonMobile = mobileNR;
                    }
                    else
                    {
                        row.Telefon1 = "";
                    }

                }
                catch (Exception ex)
                {
                                        Helper.LogHelper.WriteDebugLog(ex.ToString());
                }


                this.dataSet1.Adressen.AddAdressenRow(row);

            }

        }



        private void adressenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Adressen_FormClosing(object sender, FormClosingEventArgs e)
        {
            (Application.OpenForms["Form1_main"] as Form1_main).alleAdressen = this.alleAdressen;

        }

        private void adressenDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            schreibschuetzen();

            currUniqueID = this.iDTextBox.Text;


        }

        private void checkPhone1Textbox()
        {
            bool passt = Helper.TextHelper.checkPhoneNr(this.phone1maskedTextBox.Text);
            if (passt)
            {
                this.phone1maskedTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.phone1maskedTextBox.BackColor = Color.FromArgb(
                                                    ((int)(((byte)(255)))),
                                                    ((int)(((byte)(192)))),
                                                    ((int)(((byte)(192)))));
            }
        }
        private void checkPhoneMobileTextbox()
        {
            bool passt = Helper.TextHelper.checkPhoneNr(this.telefonMobileTextBox.Text);
            if (passt)
            {
                this.telefonMobileTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.telefonMobileTextBox.BackColor = Color.FromArgb(
                                                    ((int)(((byte)(255)))),
                                                    ((int)(((byte)(192)))),
                                                    ((int)(((byte)(192)))));
            }
        }

        private void schreibschuetzen()
        {
            this.jobTitleTextBox.Enabled = false;
            this.email1AdresseTextBox.Enabled = false;
            this.phone1maskedTextBox.Enabled = false;
            this.landTextBox.Enabled = false;
            this.pLZTextBox.Enabled = false;
            this.ortTextBox.Enabled = false;
            this.strasseTextBox.Enabled = false;
            this.firmennameTextBox.Enabled = false;
            this.telefonMobileTextBox.Enabled = false;
            this.categoriesTextBox.Enabled = false;

            this.button2_speichern.Visible = false;
        }

        private void schutzAufheben()
        {
            this.jobTitleTextBox.Enabled = true;
            this.email1AdresseTextBox.Enabled = true;
            this.phone1maskedTextBox.Enabled = true;
            this.landTextBox.Enabled = true;
            this.pLZTextBox.Enabled = true;
            this.ortTextBox.Enabled = true;
            this.strasseTextBox.Enabled = true;
            this.firmennameTextBox.Enabled = true;
            this.telefonMobileTextBox.Enabled = true;
            this.categoriesTextBox.Enabled = true;

            this.button2_speichern.Visible = true;
        }

        private void button1__Click(object sender, EventArgs e)
        {
            schutzAufheben();



            currUniqueID = this.iDTextBox.Text;


        }


        private void button2_speichern_Click(object sender, EventArgs e)
        {
            try
            {

                currContact = Contact.Bind((Application.OpenForms["Form1_main"] as Form1_main).service, new ItemId(currUniqueID));

                currContact.JobTitle = this.jobTitleTextBox.Text;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                    .FirstOrDefault()
                    .JobTitle = this.jobTitleTextBox.Text;

                var mail = new EmailAddress(this.email1AdresseTextBox.Text);
                currContact.EmailAddresses[EmailAddressKey.EmailAddress1] = mail;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                    .FirstOrDefault()
                    .EmailAddresses[EmailAddressKey.EmailAddress1] = mail;

                string newNR = this.phone1maskedTextBox.Text;
                currContact.PhoneNumbers[PhoneNumberKey.BusinessPhone] = newNR;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                    .FirstOrDefault()
                    .PhoneNumbers[PhoneNumberKey.BusinessPhone] = newNR;


                string newmobileNR = this.phone1maskedTextBox.Text;
                currContact.PhoneNumbers[PhoneNumberKey.MobilePhone] = newmobileNR;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                    .FirstOrDefault()
                    .PhoneNumbers[PhoneNumberKey.MobilePhone] = newmobileNR;

                // Firmenname CompanyName
                currContact.CompanyName = this.firmennameTextBox.Text;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                   .FirstOrDefault()
                   .CompanyName = this.firmennameTextBox.Text;


                PhysicalAddressEntry PABusinessEntry = new PhysicalAddressEntry();
                PABusinessEntry.Street = this.strasseTextBox.Text;
                PABusinessEntry.City = this.ortTextBox.Text;
                PABusinessEntry.PostalCode = this.pLZTextBox.Text;
                PABusinessEntry.CountryOrRegion = this.landTextBox.Text;

                currContact.PhysicalAddresses[PhysicalAddressKey.Business] = PABusinessEntry;
                alleAdressen.Where(x => x.Id.UniqueId == currUniqueID)
                    .FirstOrDefault()
                   .PhysicalAddresses[PhysicalAddressKey.Business] = PABusinessEntry;

                var categories = this.categoriesTextBox.Text.Split(' ');
                if (categories.Count() > 0)
                {
                    StringList stringList = new StringList();
                    foreach (var item in categories)
                    {
                        stringList.Add(item);
                    }

                    currContact.Categories = stringList;

                }


                // https://msdn.microsoft.com/en-us/library/office/ee693002(v=exchg.80).aspx
                currContact.Update(ConflictResolutionMode.AlwaysOverwrite);

                schreibschuetzen();
            }
            catch (Exception ex)
            {
                                    Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }

        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string suchtext = this.textBox1_suchen.Text.Trim();


            string filtertext1 = "Firmenname LIKE '*" + suchtext + "*'";
            string filtertext2 = "PLZundORT LIKE '*" + suchtext + "*'";
            string filtertext3 = "Name LIKE '*" + suchtext + "*'";
            string filtertext4 = "Land LIKE '*" + suchtext + "*'";

            this.adressenBindingSource.Filter =
                                                filtertext1 + " OR " +
                                                filtertext2 + " OR " +
                                                filtertext3 + " OR " +
                                                filtertext4;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firmennameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void landTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void phone1maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            checkPhone1Textbox();
        }

        private void button3_neue_Click(object sender, EventArgs e)
        {
            Form9_neueAdresse f9 = new Form9_neueAdresse();
            var result = f9.ShowDialog();

            this.Close();

        }

        private void button4_loeschen_Click(object sender, EventArgs e)
        {
            try
            {

                currContact = Contact.Bind((Application.OpenForms["Form1_main"] as Form1_main).service, new ItemId(currUniqueID));

                string nam = currContact.FileAs;

                var result = MessageBox.Show("Soll der Kontakt " + nam + " wirklich gelöscht werden?" + Environment.NewLine + Environment.NewLine + "der ist dann richtig weg....");

                if (result == DialogResult.OK)
                {
                    currContact.Delete(DeleteMode.MoveToDeletedItems);
                    (Application.OpenForms["Form1_main"] as Form1_main).adressenAsyncLaden();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                                    Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }

        private void button5_excel_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Das dauert ca 5-7 Minuten!" +
                Environment.NewLine + " wollen Sie das? " + Environment.NewLine + Environment.NewLine + "(am Schluss kommt dann wieder ein Popup-Fenster)", "nach Excel exportieren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Helper.ExcelExportHelper.createExcelFrom(this.dataSet1.Adressen);
                MessageBox.Show("fertig!");
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void telefonMobileTextBox_TextChanged(object sender, EventArgs e)
        {
            checkPhoneMobileTextbox();
        }

        private void button_Adresse4Lieferschein_Click(object sender, EventArgs e)
        {
            AdresseWaehlenUndSchliessen();
        }

        private void adressenDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.button_Adresse4Lieferschein.Visible == true)
            //{
                AdresseWaehlenUndSchliessen();
            //}
        }

        private void AdresseWaehlenUndSchliessen()
        {
            var rows = this.adressenDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                try
                {
                    var bounditem = rows[0].DataBoundItem;
                    var rowview = ((DataRowView)bounditem).Row;
                    this.rrrow = (DAL.DataSet1.AdressenRow)rowview;

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    //var L05 = Application.OpenForms["Lieferschein05_neuerLS"] as Lieferschein05_neuerLS;

                    //if (L05 != null)
                    //{
                    //   // var rrrow = (DAL.DataSet1.AdressenRow)rowview;
                    //    L05.Adressenrow = this.rrrow;
                    //}

                    //var R05 = Application.OpenForms["Rechnung05_neueRE"] as Rechnung05_neueRE;

                    //if (R05 != null)
                    //{
                    //   // var rrrow = (DAL.DataSet1.AdressenRow)rowview;
                    //    R05.Adressenrow = this.rrrow;
                    //}


                }
                catch (Exception ex)
                {

                    var name = "bla";
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private void button_Adresse5Rechnung_Click(object sender, EventArgs e)
        {
            AdresseWaehlenUndSchliessen();
        }
    }
}