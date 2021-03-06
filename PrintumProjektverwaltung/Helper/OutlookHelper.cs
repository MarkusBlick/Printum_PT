﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PrintumProjektverwaltung.Forms;
using PrintumProjektverwaltung.Models;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace PrintumProjektverwaltung.Helper
{
    class OutlookHelper
    {
        public static List<printumBestellPositionen> bestellliste;
        private static int projektnr;
        private static string pdfPfad;
        private static string mailPfad;

        private static Outlook.MailItem dieMail;



        public static List<printumBestellPositionen> createNewEmailmitAnhang(string pfad, string bestellnr, int _projektnr, string email)
        {
            projektnr = _projektnr;

            pdfPfad = pfad.Substring(0, pfad.Length - 4) + @".pdf";
            mailPfad = pfad.Substring(0, pfad.Length - 4) + @".msg";
            string mailtemplate = @"\\printumserver.print.local\PT-99-Vorl\Dokumente\BestellungsMail-Template.oft";

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(pfad);

            // Zeilen auslesen und in die Datenbank schreiben.
            bestellliste = ExcelHelper.getBestellPositionen(excelWorkbook, bestellnr);

            excelWorkbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfPfad);



            excelWorkbook.Close(false, pfad, null);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelWorkbook);
            Marshal.ReleaseComObject(excelApp);


            Outlook.Application app = new Outlook.Application();


            Outlook.Folder folder = app.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts) as Outlook.Folder;
            dieMail = app.CreateItemFromTemplate(mailtemplate, folder) as Outlook.MailItem;
            Outlook.Inspector mailInspector = dieMail.GetInspector;
            mailInspector.Activate();

            dieMail.Subject = "PT-PRINTUM Bestellung  " + bestellnr + "  Projekt: " + projektnr.ToString();

            dieMail.To = email;

            dieMail.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;

            //var textt = dieMail.HTMLBody;
            //textt.Replace(@"</body>", @"<b>Hinweis</b>:" +
            //                @"Bitte geben Sie immer unsere kompletten Bestelldaten(Printum Auftrags Nr.und Bestell Nr.) auf allen" +
            //                @"Schriftstücken zum Auftrag(Auftragsbestätigung, Lieferschein und Rechnung) vollständig an!" +
            //                @"Fehlende oder unvollständige Bestelldaten können ansonsten ggf. zu einem verzögertem Zahlungsausgleich führen. </body>");

            //dieMail.HTMLBody = textt;
            dieMail.Attachments.Add(
                                    pdfPfad,
                                    Outlook.OlAttachmentType.olByValue,
                                    1,
                                    "PT-PRINTUM Bestellung  " + bestellnr);

            dieMail.Display(true);
            Form4_Spinner f4 = (Application.OpenForms["Form4_Spinner"] as Form4_Spinner);
            if (f4 != null)
            {
                f4.Close();
            }

            ((Outlook.ItemEvents_10_Event)dieMail).Send += ThisMai_send;

            return bestellliste;

        }

        private static void ThisMai_send(ref bool Cancel)
        {

            if (bestellliste != null)
            {
                using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
                {
                    try
                    {
                        string bestellIdText = bestellliste[0].BestellnungIDTest;

                        DAL.Bestellungen bestellungen = (from p in db.Bestellungen
                                                         where p.BestellungIDText == bestellIdText
                                                         select p)
                                                         .First();


                        if (bestellungen != null)
                        {
                            bestellungen.geaendert = DateTime.Now;
                            bestellungen.GeaendertVon = Environment.UserName;
                            bestellungen.istAbgeschickt = true;
                            bestellungen.PDFpfad = pdfPfad;
                        }


                        foreach (var item in bestellliste)
                        {
                            DAL.BestellungPositionen bestellungPositionen = new DAL.BestellungPositionen();
                            bestellungPositionen.Artikelbezeichnung = item.Artikelbezeichnung;
                            bestellungPositionen.BestellnungIDTest = item.BestellnungIDTest;
                            bestellungPositionen.Einzelpreis = item.Einzelpreis;
                            bestellungPositionen.Gesammtpreis = item.Gesammtpreis;
                            bestellungPositionen.Liefertermin = item.Liefertermin;
                            bestellungPositionen.Pos = item.Pos;
                            bestellungPositionen.Projektnummer = projektnr;
                            bestellungPositionen.Stueck = item.Stueck;
                            bestellungPositionen.Besteller = Environment.UserName;
                            bestellungPositionen.Bestelldatum = DateTime.Now;

                            db.BestellungPositionen.Add(bestellungPositionen);
                        }
                        db.SaveChanges();
                        dieMail.SaveAs(mailPfad);

                        (Application.OpenForms["Form1_main"] as Form1_main).BestellungenNeuLaden();

                    }
                    catch (Exception ex)
                    {
                        Helper.LogHelper.WriteDebugLog(ex.ToString());
                    }
                    finally
                    {
                        if ((Application.OpenForms["Form1_main"] as Form1_main)
                            .Controls["button4_mail"] != null)
                        {
                            (Application.OpenForms["Form1_main"] as Form1_main)
                                                       .Controls["button4_mail"].Enabled = true;
                        }


                    }
                }
            }
        }





    }
}
