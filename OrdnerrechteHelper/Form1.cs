using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PrintumProjektverwaltung.Helper;

namespace OrdnerrechteHelper
{
    public partial class Form1 : Form
    {

        public List<Projekte> Projektes = new List<Projekte>();
        int der;

        public Form1()
        {
            InitializeComponent();

            der = 0;

            using (var db = new PrintumTechnologyDBEntities2())
            {
                var q = from p in db.Projekte
                        select p;
                if (q.Count() > 0)
                {
                    Projektes = q.ToList();
                }

                foreach (var pro in Projektes)
                {
                    textBox1_ordner.Text += pro.RootOrdner + Environment.NewLine;
                }

                OrdnerAufzeigen();
            }
        }

        private void RechteSetzen(Projekte pro)
        {

            string pfad = pro.RootOrdner.Replace("PRINTUMSERVER", "192.168.26.250");
            if (Directory.Exists(pfad))
            {
                var dirinfo = new DirectoryInfo(pfad);
                try
                {


                    foreach (var dir in dirinfo.GetDirectories())
                    {
                       // die Rechnungen werden anders behandelt
                        if (dir.Name.Contains("Rechnungen"))
                        {
                            HandleRechnungen(dir);
                        }
                        // alle anderen sind für Domänenbenutzer zugänglich
                        else
                        {
                            HandleDefault(dir);
                        }
                    }

                }
                catch (Exception ex)
                {
                    LogHelper.WriteDebugLog(ex.ToString());
                }
            }
            else
            {
                LogHelper.WriteDebugLog("Den Pfad gibts nicht: " + pfad);
            }

        }



        private void HandleDefault(DirectoryInfo dir)
        {
            try
            {
                // Domänenbenutzer suchen


                // Domänenbenutzer schreiblesezugriff

            }
            catch (Exception ex)
            {
                LogHelper.WriteDebugLog(ex.ToString());
            }
        }



        private void HandleRechnungen(DirectoryInfo dir)
        {
            try
            {
                // Domänenbenutzer rausnehmen


                // sekretariat schreiblesezugriff

            }
            catch (Exception ex)
            {
                LogHelper.WriteDebugLog(ex.ToString());
            }
        }




        private void OrdnerAufzeigen()
        {
            textBox1.Text = "";
            string pfad = Projektes[der].RootOrdner.Replace("PRINTUMSERVER", "192.168.26.250");
            if (Directory.Exists(pfad))
            {
                var dirinfo = new DirectoryInfo(pfad);
                foreach (var dir in dirinfo.GetDirectories())
                {
                    textBox1.Text += dir.FullName + Environment.NewLine;
                    if (dir.Name.Contains("Rechnungen"))
                    {
                        LogHelper.WriteDebugLog(dir.Name);
                    }
                }
            }

        }

        private void button2_rechtesetzen_Click(object sender, EventArgs e)
        {
            if (der < Projektes.Count() - 1)
            {
                der += 1;
            }
            else
            {
                der = 0;
            }
            OrdnerAufzeigen();
        }

        private void button1_auslesen_Click(object sender, EventArgs e)
        {

        }
    }
}
