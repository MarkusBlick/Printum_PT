﻿using System;
using System.IO;

namespace PrintumProjektverwaltung.Helper
{
    internal class folderHelper
    {
        internal static void deleteFolder(string rootOrdner)
        {
            string archiv = @"\\192.168.26.250\99-Vorlagen\PrintumProjekte gelöscht";
            try
            {
                Directory.Move(rootOrdner, archiv);
            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());                
            }
        }
    }
}