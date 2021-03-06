﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Rechnung07_Zahlungen : Form
    {
        private DataGridViewRow row;
        private int dieID;

        public Rechnung07_Zahlungen()
        {
            InitializeComponent();
        }

        public Rechnung07_Zahlungen(DataGridViewRow row)
        {
            InitializeComponent();

            this.row = row;

            var rId = row.Cells["PriProRechnungID"].Value;
            if (rId != null)
            {
                dieID = (int)rId;
            }

            var rechnungsbetrag = row.Cells["Rechnungsbetrag"].Value.ToString();
            var zahlungsbetrag = row.Cells["Zahlungsbetrag"].Value.ToString();
            var zahldatum = row.Cells["Zahlungsdatum"].Value.ToString();
            var mahnung1datum = row.Cells["Mahnung1datum"].Value.ToString();
            var mahnung2datum = row.Cells["Mahnung2datum"].Value.ToString();
            var mahnung3datum = row.Cells["Mahnung3datum"].Value.ToString();
            var zahlungsziel = row.Cells["Zahlungsziel"].Value.ToString();
            var bemerkungen = row.Cells["Bemerkungen"].Value.ToString();

            rechnungBetragTextBox.Text = rechnungsbetrag;
            zahlungsBetragTextBox.Text = zahlungsbetrag;
            zahlungsDatumTextBox.Text = MachSchoenesDatum(zahldatum);
            mahnung1textBox.Text = MachSchoenesDatum(mahnung1datum);
            mahnung2textBox.Text = MachSchoenesDatum(mahnung2datum);
            mahnung3textBox.Text = MachSchoenesDatum(mahnung3datum);
            zahlungsZielTextBox.Text = MachSchoenesDatum(zahlungsziel);
            bemerkungTextBox.Text = bemerkungen;



        }



        private string MachSchoenesDatum(string datum)
        {
            if (datum.Length>10)
            {
                return datum.Substring(0, 10);
            }
            else
            {
                return datum;
            }
        }

        private void button2_adresse_Click(object sender, EventArgs e)
        {
            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {

                var dieRow = db.PriProRechnung.Find(dieID);

                if (rechnungBetragTextBox.Text != "")
                {
                    double reb;
                    try
                    {
                        reb = Convert.ToDouble(rechnungBetragTextBox.Text);
                        dieRow.Rechnungsbetrag = reb;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (zahlungsBetragTextBox.Text != "")
                {
                    double zbe;
                    try
                    {
                        zbe = Convert.ToDouble(zahlungsBetragTextBox.Text);
                        dieRow.Zahlungsbetrag = zbe;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (zahlungsDatumTextBox.Text != "")
                {
                    DateTime zdt;
                    try
                    {
                        zdt = Convert.ToDateTime(zahlungsDatumTextBox.Text);
                        dieRow.Zahlungsdatum = zdt;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (mahnung1textBox.Text != "")
                {
                    DateTime zdt;
                    try
                    {
                        zdt = Convert.ToDateTime(mahnung1textBox.Text);
                        dieRow.Mahnung1datum = zdt;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (mahnung2textBox.Text != "")
                {
                    DateTime zdt;
                    try
                    {
                        zdt = Convert.ToDateTime(mahnung2textBox.Text);
                        dieRow.Mahnung2datum = zdt;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (mahnung3textBox.Text != "")
                {
                    DateTime zdt;
                    try
                    {
                        zdt = Convert.ToDateTime(mahnung3textBox.Text);
                        dieRow.Mahnung3datum = zdt;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }



                if (zahlungsZielTextBox.Text != "")
                {
                    DateTime zdt;
                    try
                    {
                        zdt = Convert.ToDateTime(zahlungsZielTextBox.Text);
                        dieRow.Zahlungsziel = zdt;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }


                if (bemerkungTextBox.Text != "")
                {
                    
                    try
                    {
                        
                        dieRow.Bemerkungen = bemerkungTextBox.Text;
                    }
                    catch (Exception ex)
                    {
                        var bal = ex.ToString();
                    }
                }

                db.Entry(dieRow).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
