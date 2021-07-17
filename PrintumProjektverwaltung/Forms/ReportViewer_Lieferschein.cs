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
using DevExpress.XtraPrinting;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Models;
using PrintumProjektverwaltung.Reports;

namespace PrintumProjektverwaltung.Forms
{
    public partial class ReportViewer_Lieferschein : Form
    {
        public DataSet1.LieferungLieferscheinRow neueRow;

        XtraReport2_LieferungLieferschein1 r1;

        internal printumLieferung DieLieferung { get; set; }

        public ReportViewer_Lieferschein()
        {
            InitializeComponent();
            r1 = new XtraReport2_LieferungLieferschein1();

        }

        private void ReportViewer_Lieferschein_Load(object sender, EventArgs e)
        {
            this.lieferungLieferscheinTableAdapter1.Fill(this.dataSet11.LieferungLieferschein);
            neueRow = this.dataSet11.LieferungLieferschein.NewLieferungLieferscheinRow();

            neueRow.LieferscheinID = GetNewLieferscheinID();
            neueRow.LieferscheinNummer = "L-" + neueRow.LieferscheinID.ToString();
            this.DieLieferung.LieferscheinNummer = neueRow.LieferscheinNummer;

            ReportErstellen();
        }


        private void ReportErstellen()
        {



            try
            {
                BindingSource b2 = new BindingSource();
                b2.DataSource = DieLieferung;

                var positionen = DieLieferung.lieferungPositionen;

                r1.DataSource = b2;
                r1.DataMember = "LieferungPositionen"; // ganz ganz wichtig!!

                this.r1.Parameters["p1_anrede"].Value = this.textBox1.Text;
                this.r1.Parameters["p2_ersterText"].Value = this.textBox2.Text;
                this.r1.Parameters["p3_zweiterText"].Value = this.textBox3.Text;
                this.r1.Parameters["p4_gruss"].Value = this.textBox4.Text;

                r1.RequestParameters = false;


                r1.CreateDocument();
            }
            catch (Exception ex)
            {
                                    Helper.LogHelper.WriteDebugLog(ex.ToString());
            }

            this.documentViewer1.DocumentSource = r1;
        }





        private void button1_uebertragen_Click(object sender, EventArgs e)
        {
            this.documentViewer1.DocumentSource = null;
            ReportErstellen();

        }

        // speichern
        private void button1_Click(object sender, EventArgs e)
        {
            this.neueRow.LieferscheinPfadPDF = getThePath();
            this.neueRow.Lieferscheintext1 = this.textBox1.Text;
            this.neueRow.Lieferscheintext2 = this.textBox2.Text;
            this.neueRow.Lieferscheintext3 = this.textBox3.Text;
            this.neueRow.Lieferscheintext4 = this.textBox4.Text;

            this.neueRow.LieferscheinErstelltVon = System.Environment.UserName;
            this.neueRow.LieferscheinErstelltAm = DateTime.Now;
            this.neueRow.AuftagID = this.DieLieferung.AuftagID;

            alsPDFspeichern(this.neueRow.LieferscheinPfadPDF);

            try
            {
                this.dataSet11.LieferungLieferschein.AddLieferungLieferscheinRow(neueRow);
                this.lieferungLieferscheinTableAdapter1.Update(this.dataSet11);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Fehler beim Speichern in die Datenbank" + Environment.NewLine + Environment.NewLine + ex.ToString());
            }
            this.Close();
        }



        private int GetNewLieferscheinID()
        {
            int neueID;

            // für das erste Mal
            if (this.dataSet11.Lieferung.Count == 0)
            {
                var jahrundtext = DateTime.Now.Year.ToString() + "0501";
                bool geklappt = Int32.TryParse(jahrundtext, out neueID);
            }
            else
            {
                int dashoechste =
                      (from p in dataSet11.LieferungLieferschein
                       select p.LieferscheinID).Max();


                string strHoechste = dashoechste.ToString();
                string dasJahrstr = strHoechste.Substring(0, strHoechste.Length - 4);
                int dasJahr = -1;
                bool geklappt = Int32.TryParse(dasJahrstr, out dasJahr);

                if (DateTime.Now.Year > dasJahr)
                {
                    var jahrundtext = DateTime.Now.Year.ToString() + "0501";
                    bool wiedergeklappt = Int32.TryParse(jahrundtext, out neueID);
                }
                else
                {
                    neueID = dashoechste + 1;
                }
            }


            return neueID;
        }


        private string alsPDFspeichern( string reportPath)
        {

            //string reportPath = getThePath();


            PdfExportOptions pdfOptions = r1.ExportOptions.Pdf;

            // Specify the pages to be exported.
            //     pdfOptions.PageRange = "1, 3-5";

            // Specify the document options.
            pdfOptions.DocumentOptions.Application = "PriPro";
            pdfOptions.DocumentOptions.Author = "Automatisch erstellt";
            pdfOptions.DocumentOptions.Keywords = "PriPro, Reporting, PDF";
            pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
            pdfOptions.DocumentOptions.Subject = "Lieferung";
            pdfOptions.DocumentOptions.Title = "Lieferschein";


            try
            {
                r1.ExportToPdf(reportPath, pdfOptions);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Fehler beim erstellen der PDF" + Environment.NewLine + Environment.NewLine + ex.ToString());
            }


            return reportPath;
        }



        private string getThePath()
        {
            string derPfad = "";

            using (DAL.PrintumProjekteEntities db = new PrintumProjekteEntities())
            {
                var q = from p in db.Projekte
                        where this.DieLieferung.Projektnummer == p.Projektnummer
                        select p;
                if (q.Count() > 0)
                {
                    derPfad = q.First().RootOrdner;

                    // Switch für die Entwicklungsumgebung, 
                    // .. die ist nicht im Firmennetzt deshalb funktionieren nur nackte IPs
                    if (!Directory.Exists(@"\\printumserver.print.local\PT-99-Vorl") && derPfad != null)
                    {
                        string help = q.First().RootOrdner;
                        derPfad = help.Replace(@"\\printumserver.print.local\", @"\\192.168.26.250\");
                    }
                }
            }

            derPfad = Path.Combine(derPfad, @"14 Lieferscheine");

            if (!Directory.Exists(derPfad))
            {
                try
                {
                    Directory.CreateDirectory(derPfad);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Fehler beim erstellen des Ordners" + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }

            derPfad = Path.Combine(derPfad, this.DieLieferung.LieferscheinNummer + "_" + this.DieLieferung.AdressLieferName + ".pdf");



            return derPfad;
        }



    }
}
