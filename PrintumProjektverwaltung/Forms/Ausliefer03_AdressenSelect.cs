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
    public partial class Ausliefer03_AdressenSelect : Form
    {

        public List<Contact> alleAdressen;
        private Contact currContact;
        public string currUniqueID;

        public Ausliefer03_AdressenSelect()
        {
            InitializeComponent();
        }

        private void Ausliefer03_AdressenSelect_Load(object sender, EventArgs e)
        {
            this.alleAdressen = (Application.OpenForms["Form1_main"] as Form1_main).alleAdressen;
            //  die Outlookadressen werden auseglesen  
            dieInfoAdressenAuslesen();

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


                    //PhysicalAddressEntry pEntry;
                    //PhysicalAddressKey pKey = PhysicalAddressKey.Business;
                    //if (adr.PostalAddressIndex.HasValue)
                    //{
                    //    row.Strasse = (entry.Street == null) ? "" : entry.Street;
                    //    row.Ort = (entry.City == null) ? "" : entry.City;
                    //    row.PLZ = (entry.PostalCode == null) ? "" : entry.PostalCode;
                    //    row.Land = (entry.CountryOrRegion == null) ? "" : entry.CountryOrRegion;
                    //    row.PLZundORT = row.PLZ + " " + row.Ort;

                    //    row.Matchcode += row.PLZundORT;
                    //}


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
                    var bla = ex.ToString();
                }


                this.dataSet1.Adressen.AddAdressenRow(row);

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

        private void button_adresse_Click(object sender, EventArgs e)
        {
            adresseWaehlenUndSchliessen();
        }

        private void adresseWaehlenUndSchliessen()
        {
            var rows = this.adressenDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                try
                {
                    var bounditem = rows[0].DataBoundItem;
                    var rowview = ((DataRowView)bounditem).Row;

                    var A02 = Application.OpenForms["Ausliefer02_neu"] as Ausliefer02_neu;
                    var A05 = Application.OpenForms["Ausliefer05_aendern"] as Ausliefer05_aendern;

                    if (A02 != null)
                    {
                        A02.currAdress = (DAL.DataSet1.AdressenRow)rowview;
                    }

                    if (A05 != null)
                    {
                        A05.currAdress = (DAL.DataSet1.AdressenRow)rowview;
                    }
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

        private void adressenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adresseWaehlenUndSchliessen();
        }
    }
}
