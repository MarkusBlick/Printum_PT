using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using PrintumProjektverwaltung.DAL;
using Excel = Microsoft.Office.Interop.Excel;



namespace PrintumProjektverwaltung.Helper
{
    internal class ExcelHelperRechnung
    {
        private static Excel.Application excelApp;
        private static Excel.Workbook excelWorkbook;
        private static Excel.Worksheet excelSheet;

       // private static string root = @"\\printumserver.print.local\PT-99-Vorl\Dokumente\";
        private static string root = @"\\printumserver.print.local\PT-99-Vorl\Dokumente\Archiv UF\";
        private static string excelTemplate = "";



        internal static void CreateNewExcel(DataSet1.PriProRechnungRow newrow, string v)
        {
            if (v == "Standard")
            {
                excelTemplate = root + @"Rechnung_Standard.xlsx";
            }
            if (v == "Dienstleistung")
            {
                excelTemplate = root + @"Rechnung_Dienstleistung.xlsx";

            }
            if (v == "AZ1")
            {
                excelTemplate = root + @"Rechnung_AZ1.xlsx";

            }
            if (v == "AZ2")
            {
                excelTemplate = root + @"Rechnung_AZ2.xlsx";

            }
            if (v == "AZ3")
            {
                excelTemplate = root + @"Rechnung_AZ3.xlsx";

            }
            if (v == "AZ4")
            {
                excelTemplate = root + @"Rechnung_AZ4.xlsx";

            }


            if (v == "StandardEN")
            {
                excelTemplate = root + @"Invoice_Standard.xlsx";
            }
            if (v == "DienstleistungEN")
            {
                excelTemplate = root + @"Invoice_Dienstleistung.xlsx";

            }
            if (v == "AZ1EN")
            {
                excelTemplate = root + @"Invoice_AZ1.xlsx";

            }
            if (v == "AZ2EN")
            {
                excelTemplate = root + @"Invoice_AZ2.xlsx";

            }
            if (v == "AZ3EN")
            {
                excelTemplate = root + @"Invoice_AZ3.xlsx";

            }
            if (v == "AZ4EN")
            {
                excelTemplate = root + @"Invoice_AZ4.xlsx";

            }


            if (File.Exists(excelTemplate))
            {

                createNewRechnung(newrow);

            }
            else
            {
                MessageBox.Show("Keine Vorlage vorhanden.");
            }
        }

        private static void createNewRechnung(DataSet1.PriProRechnungRow newrow)
        {


            string destination = newrow.RechnungPfad;

            try
            {


                File.Copy(excelTemplate, destination, true);




            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog("excelTemplate: " + excelTemplate + Environment.NewLine
                    + "destination: " + destination + Environment.NewLine +
                    ex.ToString()
                    );
            }


            // das Excelsheet offnen
            if (File.Exists(destination))
            {


                try
                {
                    // die Excelanwendung
                    excelApp = new Excel.Application();
                    excelApp.DisplayAlerts = false;



                    // die Excelmappe
                    excelWorkbook = excelApp.Workbooks.Open(destination,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                Type.Missing, Type.Missing);

                    int anzahlBlaetter = excelWorkbook.Sheets.Count;
                    if (anzahlBlaetter > 0)
                    {

                        // das Excelblatt
                        excelSheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                        diePlatzhalterBefuellen(excelSheet, newrow);

                        excelWorkbook.Save();

                    }



                    // alles beenden und freigeben
                    excelWorkbook.Close(false, destination, null);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelWorkbook);
                    Marshal.ReleaseComObject(excelApp);

                    System.Diagnostics.Process.Start(destination);

                }
                catch (Exception ex)
                {
                    Helper.LogHelper.WriteDebugLog(ex.ToString());

                }

            }
        }


        private static void diePlatzhalterBefuellen(Excel.Worksheet excelSheet, DataSet1.PriProRechnungRow dieRow)
        {

            try
            {
                excelSheet.Rows.Replace(What: "####Rechnungsnummer####", Replacement: dieRow.RechnungNr);
                var middleHeader = excelSheet.PageSetup.CenterHeader.Replace("####Rechnungsnummer####", dieRow.RechnungNr);
                excelSheet.PageSetup.CenterHeader = middleHeader;

                excelSheet.Rows.Replace(What: "####Datum####", Replacement: DateTime.Now.Date.ToShortDateString());


                if (dieRow.IsRE_FirmennameNull() == false)
                {
                    excelSheet.Rows.Replace(What: "####Firmenname####", Replacement: dieRow.RE_Firmenname);
                }

                if (dieRow.IsRE_StrasseNull() == false)
                {
                    excelSheet.Rows.Replace(What: "####Strasse####", Replacement: dieRow.RE_Strasse);
                }

                if (dieRow.IsRE_StadtNull() == false)
                {
                    excelSheet.Rows.Replace(What: "####PLZundORT####", Replacement: dieRow.RE_PLZ + " " + dieRow.RE_Stadt);
                }

                if (dieRow.IsLieferscheinNrNull() == false)
                {
                    excelSheet.Rows.Replace(What: "####Lieferscheinnummer####", Replacement: dieRow.LieferscheinNr);
                }
                else
                {
                    excelSheet.Rows.Replace(What: "####Lieferscheinnummer####", Replacement: "");
                }

                if (dieRow.IsProjektnummerNull() == false)
                {
                    excelSheet.Rows.Replace(What: "####Projektnummer####", Replacement: dieRow.Projektnummer.ToString());
                    var middleHeaderPRo = excelSheet.PageSetup.CenterHeader.Replace("####Projektnummer####", dieRow.Projektnummer.ToString());
                    excelSheet.PageSetup.CenterHeader = middleHeaderPRo;
                }


                //var leftHeader = excelSheet.PageSetup.LeftHeader.Replace(" ####Ansprechpartner####", neueBestellung.BestellungIDText);
                //var middleHeader = excelSheet.PageSetup.CenterHeader.Replace("####Datum####", neueBestellung.ProjektnummerText);


                //excelSheet.PageSetup.LeftHeader = leftHeader;
                //excelSheet.PageSetup.CenterHeader = middleHeader;


            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }


    }
}