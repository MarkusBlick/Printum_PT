using System;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Models;
using Excel = Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Exchange.WebServices.Data;
using System.Reflection;

namespace PrintumProjektverwaltung.Helper
{
    class ExcelExportHelper
    {

        private static Excel.Application excelApp;
        private static Excel.Workbook excelWorkbook;
        private static Excel.Worksheet excelSheet;


        private static string pfad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
            + "\\Adressen_"
            + DateTime.Now.Year.ToString() + "-"
            + DateTime.Now.Month.ToString() + "-"
            + DateTime.Now.Day.ToString()
            +".xlsx";


        internal static void createExcelFrom(DataSet1.AdressenDataTable adressen)
        {
            try
            {
                // die Excelanwendung
                excelApp = new Excel.Application();
                excelApp.DisplayAlerts = false;


                // die Excelmappe
                excelWorkbook = excelApp.Workbooks.Add();

                int anzahlBlaetter = excelWorkbook.Sheets.Count;
                if (anzahlBlaetter > 0)
                {

                    // das Excelblatt
                    excelSheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                    // die Überschriften
                    for (int i = 0; i < adressen.Columns.Count; i++)
                    {
                        ((Excel.Range)excelSheet.Cells[1, i + 1]).Value2 = adressen.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < adressen.Rows.Count; i++)
                    {
                        var row = adressen.Rows[i];

                        for (int j = 0; j < row.ItemArray.Length; j++)
                        {
                            ((Excel.Range)excelSheet.Cells[i + 2, j + 1]).Value2 = row.ItemArray[j].ToString();
                        }
                    }

                }

                excelWorkbook.SaveAs(pfad, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Excel.XlSaveAsAccessMode.xlNoChange,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);




            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());

            }
            finally
            {

                // alles beenden und freigeben
                excelWorkbook.Close(false, pfad, null);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApp);

            }
        }

    }
}
