using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Models;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Form1_1_Projektname : Form
    {
        private object derTag;
        private printumProjekt dasP;

        public Form1_1_Projektname()
        {
            InitializeComponent();
        }

        public Form1_1_Projektname(object derTag)
        {
            InitializeComponent();

            this.derTag = derTag;

        }

        private void button1_speichern_Click(object sender, EventArgs e)
        {
            bool bistInDomaene = Directory.Exists(@"\\PRINTUMSERVER\PT-PriPro");

            string sourceDirectory = dasP.RootOrdner;
            string destinationDirectory = @"\\PRINTUMSERVER\PT-PriPro\"
                                           + dasP.Projektnummer + @" - " + textBox1.Text.Trim();




            if (bistInDomaene == false)
            {
                sourceDirectory = sourceDirectory.Replace("PRINTUMSERVER", "192.168.26.250");
                destinationDirectory = destinationDirectory.Replace("PRINTUMSERVER", "192.168.26.250");
            }

            var replaceSource = sourceDirectory.Substring(sourceDirectory.IndexOf("PT-PriPro"));
            var replacedest = destinationDirectory.Substring(destinationDirectory.IndexOf("PT-PriPro"));


            var ADUser_Id = "PRINT\\erp"; //make sure user name has domain name.
            var Password = "Bernd$Finest";
            using (var domainContext = new PrincipalContext(ContextType.Domain, "192.168.26.250", ADUser_Id, Password))
            {
                string alleSchreibbar = "";
                using (var user = new UserPrincipal(domainContext))
                {
                    alleSchreibbar = CheckDieFiles(sourceDirectory);
                    if (alleSchreibbar.Count()>0)
                    {


                        try
                        {
                        //DirectoryInfo disource = new DirectoryInfo(sourceDirectory);

                        //Directory.Move(sourceDirectory, destinationDirectory);


                            DirectoryCopy(sourceDirectory, destinationDirectory, true);


                            try
                            {


                                Directory.Delete(sourceDirectory, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Da hat was nicht geklappt" + Environment.NewLine + Environment.NewLine
                                    + " bei Directory.Delete"
                                    + Environment.NewLine + Environment.NewLine
                                    + Environment.NewLine + Environment.NewLine + ex.ToString());
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Da hat was nicht geklappt" + Environment.NewLine + Environment.NewLine
                                + " bei DirectoryCopy"
                                + Environment.NewLine + Environment.NewLine
                                + Environment.NewLine + Environment.NewLine + ex.ToString());


                        }



                    }
                    else
                    {
                        MessageBox.Show("Umbenennen geht nicht , denn folgende Dateien sind noch offen:" + Environment.NewLine +
                            alleSchreibbar);
                    }
                }
            }




            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {
                // Lieferscheine finden
                try
                {


                    List<PriProLieferscheinRechnung> Lieferscheine = getLieferscheine(db);
                    if (Lieferscheine.Count() > 0)
                    {
                        foreach (var item in Lieferscheine)
                        {


                            var newPfad = item.LieferscheinPfad.Replace(replaceSource, replacedest);
                            item.LieferscheinPfad = newPfad;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Da hat was nicht geklappt" + Environment.NewLine + Environment.NewLine
                        + " Replace Lieferscheine"
                        + Environment.NewLine + Environment.NewLine
                        + Environment.NewLine + Environment.NewLine + ex.ToString());


                }

                // Bestellungen finden
                try
                {


                    List<Bestellungen> Bestellungen = getBestellungen(db);
                    if (Bestellungen.Count() > 0)
                    {
                        foreach (var item in Bestellungen)
                        {


                            var pfadSpeicherort = item.Speicherort.Replace(replaceSource, replacedest);
                            item.Speicherort = pfadSpeicherort;



                            var pfadPdf = item.PDFpfad.Replace(replaceSource, replacedest);
                            item.PDFpfad = pfadPdf;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Da hat was nicht geklappt" + Environment.NewLine + Environment.NewLine
                        + " Replace Bestellung"
                        + Environment.NewLine + Environment.NewLine
                        + Environment.NewLine + Environment.NewLine + ex.ToString());


                }




                // Datenbank speichern
                datenbankSpeichern(db, destinationDirectory);
            }
            Close();

        }

        private string CheckDieFiles(string sourceDirectory)
        {
            string blockedFile = "";
            DirectoryInfo dirinf = new DirectoryInfo(sourceDirectory);
            foreach (var file in dirinf.GetFiles())
            {

                try
                {
                    using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        stream.Close();
                    }
                }
                catch (IOException)
                {
                    //the file is unavailable because it is:
                    //still being written to
                    //or being processed by another thread
                    //or does not exist (has already been processed)
                    blockedFile += file.FullName + Environment.NewLine;
                }

            }

            var subdirs = dirinf.GetDirectories();
            foreach (var subdir in subdirs)
            {
                blockedFile += CheckDieFiles(subdir.FullName);
            }

            return blockedFile;
        }

        private List<Bestellungen> getBestellungen(PrintumProjekteEntities db)
        {
            List<Bestellungen> liste = new List<Bestellungen>();

            var q = from p in db.Bestellungen
                    where p.Projektnummer == dasP.Projektnummer
                    select p;
            liste = q.ToList();
            return liste;
        }

        private List<PriProLieferscheinRechnung> getLieferscheine(PrintumProjekteEntities db)
        {
            List<PriProLieferscheinRechnung> liste = new List<PriProLieferscheinRechnung>();

            var q = from p in db.PriProLieferscheinRechnung
                    where p.Projektnummer == dasP.Projektnummer
                    select p;
            liste = q.ToList();
            return liste;

        }


        private void datenbankSpeichern(PrintumProjekteEntities db, string destinationDirectory)
        {

            // Datenbankname ändern

            var q = (from p in db.Projekte
                     where p.Projektnummer == dasP.Projektnummer
                     select p)
                    .FirstOrDefault();
            q.Projektname = textBox1.Text.Trim();
            q.RootOrdner = destinationDirectory;
            db.SaveChanges();


        }

        private void Form1_1_Projektname_Load(object sender, EventArgs e)
        {
            Helper.LogHelper.WriteDebugLog("Projektname kann gändert werden");

            try
            {
                dasP = (printumProjekt)derTag;
                label1.Text = dasP.Projektnummer.ToString();
                label2.Text = dasP.Projektname;
                textBox1.Text = dasP.Projektname;
            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }


        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
