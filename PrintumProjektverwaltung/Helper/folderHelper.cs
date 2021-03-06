﻿using System;
using System.IO;
using System.Security.AccessControl;

namespace PrintumProjektverwaltung.Helper
{
    internal class folderHelper
    {
        internal static void deleteFolder(string rootOrdner)
        {
            string archiv = @"\\printumserver.print.local\PT-99-Vorl\PrintumProjekte gelöscht";
            try
            {
                Directory.Move(rootOrdner, archiv);
            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }



        public static void FolderCopy(String sourceFolder, String destinationFolder)
        {

            DirectoryInfo sourceDirectory = new DirectoryInfo(sourceFolder);
            DirectoryInfo destinationDirectory;

            if (!sourceDirectory.Exists)
            {
                throw new DirectoryNotFoundException("Source folder not found: " + sourceFolder);
            }

            if (!Directory.Exists(destinationFolder))
            {
                destinationDirectory = Directory.CreateDirectory(destinationFolder);
            }
            else
            {
                destinationDirectory = new DirectoryInfo(destinationFolder);
            }

            try
            {



                DirectorySecurity security = sourceDirectory.GetAccessControl();

                security.SetAccessRuleProtection(true, true);
                destinationDirectory.SetAccessControl(security);

                var filesToCopy = sourceDirectory.GetFiles();

                foreach (FileInfo file in filesToCopy)
                {
                    String path = Path.Combine(destinationFolder, file.Name);
                    FileSecurity fileSecurity = file.GetAccessControl();

                    fileSecurity.SetAccessRuleProtection(true, true);

                    file.CopyTo(path, false);

                    FileInfo copiedFile = new FileInfo(path);

                    copiedFile.SetAccessControl(fileSecurity);
                }

            }
            catch (Exception ex)
            {
                Helper.LogHelper.WriteDebugLog(ex.ToString());
            }
        }


    }




}