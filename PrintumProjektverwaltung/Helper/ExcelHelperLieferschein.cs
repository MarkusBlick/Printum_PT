using System;
using PrintumProjektverwaltung.DAL;
using Excel = Microsoft.Office.Interop.Excel;

using System.IO;
using System.Runtime.InteropServices;

namespace PrintumProjektverwaltung.Helper
{
    class ExcelHelperLieferschein
    {

        private static Excel.Application excelApp;
        private static Excel.Workbook excelWorkbook;
        private static Excel.Worksheet excelSheet;



        private static string vorlageFileBlanko = @"\\192.168.26.250\99-Vorlagen\Dokumente\Lieferschein_Blanko-Template.xlsx";
        private static string vorlageFileUnterschrift = @"\\192.168.26.250\99-Vorlagen\Dokumente\Lieferschein_Unterschrift-Template.xlsx";
        private static string vorlageFileLKW = @"\\192.168.26.250\99-Vorlagen\Dokumente\Lieferschein_LKW-Template.xlsx";
        private static string vorlageFile;


        internal static void createNewExcel(DataSet1.PriProLieferscheinRechnungRow newrow, string welcher)
        {
            if (welcher == "blanko")
            {
                vorlageFile = vorlageFileBlanko;
            }
            if (welcher == "Unterschrift")
            {
                vorlageFile = vorlageFileUnterschrift;
            }
            if (welcher == "LKW")
            {
                vorlageFile = vorlageFileLKW;
            }
            if (vorlageFile != null)
            {
                createNewExcel(newrow);
            }
        }

        public static void createNewExcel(DataSet1.PriProLieferscheinRechnungRow newRow)
        {

            string destination = getLieferscheinFilename(newRow);

            try
            {
                File.Copy(vorlageFile, destination, true);


                newRow.LieferscheinPfad = destination;

            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
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

                        diePlatzhalterBefuellen(excelSheet, newRow);

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


        //private static int getAnfangDerTabelle(Excel.Range zeilen)
        //{
        //    int zeilenindex = -1;


        //    int allezeilen = zeilen.Rows.Count;

        //    for (int i = 15; i < allezeilen; i++)
        //    {
        //        try
        //        {
        //            Excel.Range zeile = ((Excel.Range)zeilen.Rows[i]);

        //            // var zeilenId = zeile.ID;
        //            var spaltenanzahl = zeile.Count;

        //            var zelle = (Excel.Range)zeile.Columns[1];

        //            if (zelle.Value == "Pos")
        //            {
        //                var zelle2 = (Excel.Range)zeile.Columns[2];
        //                string wert2 = zelle2.Value.ToString();
        //                wert2 = wert2.ToLower().Trim();
        //                if (wert2.Contains("stück")
        //                    || wert2.Contains("paar")
        //                    || wert2.Contains("liter")
        //                    || wert2.Contains("meter")
        //                    || wert2.Contains("rolle")
        //                    || wert2.Contains("fass"))
        //                {
        //                    var zelle3 = (Excel.Range)zeile.Columns[3];
        //                    if (zelle3.Value == "Artikel")
        //                    {
        //                        // hier sollte klar sein , dass wir in der ersten Zeile der Tabellesind...
        //                        zeilenindex = i + 1;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Helper.LogHelper.WriteDebugLog(ex.ToString());
        //        }

        //    }

        //    return zeilenindex;
        //}

        //private static int getEndeDerTabelle(Excel.Range zeilen)
        //{

        //    int iPos = getAnfangDerTabelle(zeilen);



        //    int zeilenindex = -1;


        //    int allezeilen = zeilen.Rows.Count;

        //    for (int i = iPos; i < allezeilen; i++)
        //    {
        //        try
        //        {
        //            // Excel.Range zeile = ((Excel.Range)zeilen.Rows[i]);


        //            Excel.Range _cellPos = (Excel.Range)(zeilen.Cells[i, 1]);
        //            Excel.Range _cellStueck = (Excel.Range)(zeilen.Cells[i, 2]);
        //            Excel.Range _cellPreis = (Excel.Range)(zeilen.Cells[i, 5]);
        //            Excel.Range _cellGesammt = (Excel.Range)(zeilen.Cells[i, 6]);



        //            string _0Value = _cellPos.Value2 != null ? _cellPos.Value2.ToString() : "";
        //            string _1Value = _cellStueck.Value2 != null ? _cellStueck.Value2.ToString() : "";
        //            string _2Format = _cellPreis.Value2 != null ? _cellPreis.NumberFormat : "";
        //            string _3Format = _cellGesammt.Value2 != null ? _cellGesammt.NumberFormat : "";



        //            int c0;
        //            bool try0 = int.TryParse(_0Value, out c0);

        //            int c1;
        //            bool try1 = int.TryParse(_1Value, out c1);

        //            if (
        //                // _2Format.Contains("#,##0.00") == false ||
        //                //_3Format.Contains("#,##0.00") == false ||
        //                try0 == false ||
        //                try1 == false)
        //            {

        //                zeilenindex = i;
        //                break;
        //            }






        //        }
        //        catch (Exception ex)
        //        {
        //            Helper.LogHelper.WriteDebugLog(ex.ToString());
        //        }

        //    }

        //    return zeilenindex;
        //}




        private static void diePlatzhalterBefuellen(Excel.Worksheet excelSheet, DataSet1.PriProLieferscheinRechnungRow dieRow)
        {
            //bool success = excelSheet.Rows.Replace(What: "####Bestellnummer####", Replacement: "17-12345");
            try
            {
                excelSheet.Rows.Replace(What: "####Firmenname####", Replacement: dieRow.LS_Firmenname);
                excelSheet.Rows.Replace(What: "####Strasse####", Replacement: dieRow.LS_Strasse);
                excelSheet.Rows.Replace(What: "####PLZundORT####", Replacement: dieRow.LS_PLZ + " " + dieRow.LS_Stadt);

                excelSheet.Rows.Replace(What: "####Lieferscheinnummer####", Replacement: dieRow.LieferscheinNr);
                excelSheet.Rows.Replace(What: "####Projektnummer####", Replacement: dieRow.Projektnummer);
                excelSheet.Rows.Replace(What: "####Name####", Replacement: dieRow.LS_Name);
                excelSheet.Rows.Replace(What: "####Ansprechpartner####", Replacement: Environment.UserName);
                excelSheet.Rows.Replace(What: "####Datum####", Replacement: DateTime.Now.Date.ToShortDateString());

                //var leftHeader = excelSheet.PageSetup.LeftHeader.Replace(" ####Ansprechpartner####", neueBestellung.BestellungIDText);
                //var middleHeader = excelSheet.PageSetup.CenterHeader.Replace("####Datum####", neueBestellung.ProjektnummerText);


                //excelSheet.PageSetup.LeftHeader = leftHeader;
                //excelSheet.PageSetup.CenterHeader = middleHeader;

                //List<Templatmarker> liste = JsonConvert.DeserializeObject<List<Templatmarker>>(neueBestellung.Adresse);


                //foreach (var cell in liste)
                //{
                //    if (cell.MarkerName != null)
                //    {
                //        if (cell.MarkerName.Length > 0)
                //        {
                //            excelSheet.Rows.Replace(What: cell.MarkerName, Replacement: cell.MarkerWert);

                //        }
                //    }


                //}



            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }




        private static string getLieferscheinFilename(DataSet1.PriProLieferscheinRechnungRow dieRow)
        {
            string destination = "";


            try
            {
                using (DAL.PrintumProjekteEntities db = new PrintumProjekteEntities())
                {

                    var projekt = db.Projekte.Find(dieRow.Projektnummer);

                    string ordner = projekt.RootOrdner.Trim() + @"\05 Lieferscheine PriPro\";
                    ordner = fileHelper.EntwicklungsPfadHelper(ordner);
                    if (!Directory.Exists(ordner))
                    {
                        Directory.CreateDirectory(ordner);
                    }



                    destination = fileHelper.replaceInvalidChars(dieRow.LieferscheinPfad);

                    if (destination.Contains("PRINTUMSERVER"))
                    {
                        destination = destination.Replace("PRINTUMSERVER", "192.168.26.250");
                    }

                }
            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
            return destination;
        }



    }
}
