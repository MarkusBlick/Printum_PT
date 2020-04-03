using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using PrintumProjektverwaltung.Models;
using PrintumProjektverwaltung.Reports;

namespace PrintumProjektverwaltung.Forms
{
    public partial class ReportViewer1 : Form
    {
        public string str = "";
        public int bestellID;
        private printumBestellung dieBestellung;

        public ReportViewer1()
        {
            InitializeComponent();
        }

        public ReportViewer1(int bestellID)
        {

            InitializeComponent();

            this.bestellID = bestellID;

        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            dieBestellung = new printumBestellung();
            dieBestellung.Text1 = "blabla";
            fillDieBestellung();
            ReportErstellen();
        }

        private void fillDieBestellung()
        {
            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {
                var q = from p in db.Bestellungen
                        where p.Bestellung_ID == bestellID
                        select new printumBestellung
                        {
                            Bestellung_ID = p.Bestellung_ID,
                            Adresse = p.Adresse

                        };
                if (q.Count()>0)
                {
                    dieBestellung = q.ToList().First();
                    dieBestellung.Text1 = dieBestellung.Adresse;
                }
            }
        }



        private void ReportErstellen()
        {
            XtraReport1_Lieferschein1 r1 = new XtraReport1_Lieferschein1();

            List<printumBestellung> listBestellung = new List<printumBestellung>();
            listBestellung.Add(dieBestellung);

            r1.DataSource = listBestellung;

            r1.CreateDocument();



            this.documentViewer1.DocumentSource = r1;
        }

        private void Change(object sender, EventArgs e)
        {
            dieBestellung.Text1 = this.textBox1.Text;
            dieBestellung.Text2 = this.textBox2.Text;
            dieBestellung.Text3 = this.textBox3.Text;

            ReportErstellen();
        }
    }
}
