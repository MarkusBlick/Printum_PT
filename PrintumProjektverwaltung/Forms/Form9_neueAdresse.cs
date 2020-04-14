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
    public partial class Form9_neueAdresse : Form
    {
        private ExchangeService service;

        public Form9_neueAdresse()
        {
            InitializeComponent();
        }




        private void Form9_neueAdresse_Load(object sender, EventArgs e)
        {
            service = (Application.OpenForms["Form1_main"] as Form1_main).service;
        }



        private void neuenAnlegen()
        {
            try
            {
                // Create the contact.
                Contact contact = new Contact(service);

                // Specify the name and how the contact should be filed.
                contact.GivenName = this.vornameTextBox.Text;
                contact.Surname = this.nameTextBox.Text;
                contact.FileAsMapping = FileAsMapping.CompanySurnameCommaGivenName;

                // Specify the company name.
                contact.CompanyName = this.firmennameTextBox.Text;
                contact.BusinessHomePage = this.businessHomePageTextBox.Text;
                contact.JobTitle = this.jobTitleTextBox.Text;



                // Specify the business, home, and car phone numbers.
                contact.PhoneNumbers[PhoneNumberKey.BusinessPhone] = this.telefon1TextBox.Text;

                // Specify two email addresses.
                if (this.email1AdresseTextBox.Text.Count() > 0)
                {
                    contact.EmailAddresses[EmailAddressKey.EmailAddress1] = new EmailAddress(this.email1AdresseTextBox.Text);

                }
                if (this.email2AdresseTextBox.Text.Count() > 0)
                {
                    contact.EmailAddresses[EmailAddressKey.EmailAddress2] = new EmailAddress(this.email2AdresseTextBox.Text);

                }


                // Specify the buisness address.
                PhysicalAddressEntry paEntry2 = new PhysicalAddressEntry();
                paEntry2.Street = this.strasseTextBox.Text;
                paEntry2.City = this.ortTextBox.Text;
                paEntry2.PostalCode = this.pLZTextBox.Text;
                paEntry2.CountryOrRegion = this.landTextBox.Text;
                contact.PhysicalAddresses[PhysicalAddressKey.Business] = paEntry2;

                contact.Save();

            }
            catch (Exception ex)
            {
                                    Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
            // Save the contact.



        }



        private void TextBox_nichtLeer(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box != null)
            {
                if (box.Text.Count() > 0)
                {
                    box.BackColor = Color.LightGreen;
                }
                else
                {
                    box.BackColor = Color.FromArgb(
                                                        ((int)(((byte)(255)))),
                                                        ((int)(((byte)(192)))),
                                                        ((int)(((byte)(192)))));
                }
            }


        }

        private void vornameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_speichern_Click(object sender, EventArgs e)
        {
            string txt = pflichtfelderChecken();

            if (txt == "")
            {
                neuenAnlegen();
                (Application.OpenForms["Form1_main"] as Form1_main).adressenAsyncLaden();
                this.Close();

            }
            else
            {

                MessageBox.Show(txt);
            }
        }

        private string pflichtfelderChecken()
        {
            string txt = "";

            // Vorname und Nachname
            if (this.vornameTextBox.Text.Count() == 0 || this.vornameTextBox.Text == "")
            {
                txt += "Der Vorname muss eingegeben werden." + Environment.NewLine + Environment.NewLine;
            }

            if (this.nameTextBox.Text.Count() == 0 || this.nameTextBox.Text == "")
            {
                txt += "Der Nachname muss eingegeben werden." + Environment.NewLine + Environment.NewLine;
            }

            // Firmenname
            if (this.firmennameTextBox.Text.Count() == 0 || this.firmennameTextBox.Text == "")
            {
                txt += "Der Firmenname muss eingegeben werden." + Environment.NewLine + Environment.NewLine;
            }


            // Email checken
            if (this.email1AdresseTextBox.Text.Count() > 0
                && !this.email1AdresseTextBox.Text.Contains(@"@")
                && !this.email1AdresseTextBox.Text.Contains(@"."))
            {
                txt += "Also wenn schon Email1Adresse, dann aber im richtigen Format  :-) " + Environment.NewLine + Environment.NewLine;
            }

            // Email checken
            if (this.email2AdresseTextBox.Text.Count() > 0
                && !this.email2AdresseTextBox.Text.Contains(@"@")
                && !this.email2AdresseTextBox.Text.Contains(@"."))
            {
                txt += "Also wenn schon Email1Adresse, dann aber im richtigen Format  :-) " + Environment.NewLine + Environment.NewLine;
            }

            if (!Helper.TextHelper.checkPhoneNr(this.telefon1TextBox.Text))
            {
                txt += "Die Telefonnummer muss im richtigen Format eingegeben werden" + Environment.NewLine + Environment.NewLine;
            }
            return txt;
        }

        private void telefon1TextBox_TextChanged(object sender, EventArgs e)
        {
            bool passt = Helper.TextHelper.checkPhoneNr(this.telefon1TextBox.Text);
            if (passt)
            {
                this.telefon1TextBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.telefon1TextBox.BackColor = Color.FromArgb(
                                                    ((int)(((byte)(255)))),
                                                    ((int)(((byte)(192)))),
                                                    ((int)(((byte)(192)))));
            }
        }
    }
}
