using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Models;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Form1_2_Projektart : Form
    {
        private object derTag;
        private printumProjekt dasP;

        public Form1_2_Projektart()
        {
            InitializeComponent();
        }

        public Form1_2_Projektart(object derTag)
        {
            InitializeComponent();

            this.derTag = derTag;

        }

        private void button1_speichern_Click(object sender, EventArgs e)
        {

            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {

                // Datenbank speichern
                this.datenbankSpeichern(db);
            }
            Close();

        }



        private void datenbankSpeichern(PrintumProjekteEntities db)
        {

            // Datenbankname ändern

            var q = (from p in db.Projekte
                     where p.Projektnummer == dasP.Projektnummer
                     select p)
                    .FirstOrDefault();

            q.Projektart = comboBox1.SelectedItem == null ? comboBox1.Items[1].ToString() : comboBox1.SelectedItem.ToString();
            db.SaveChanges();


        }

        private void Form1_2_Projektart_Load(object sender, EventArgs e)
        {
            Helper.LogHelper.WriteDebugLog("Projektname kann gändert werden");

            try
            {
                dasP = (printumProjekt)derTag;
                label1.Text = dasP.Projektnummer.ToString();
                label2.Text = dasP.Projektname;

                if (dasP.Projektart == null)
                {
                    comboBox1.SelectedIndex = 1;
                }
                else
                {
                    comboBox1.SelectedIndex = comboBox1.FindStringExact(dasP.Projektart);
                }
            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }

    }
}
