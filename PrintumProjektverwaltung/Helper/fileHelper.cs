﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintumProjektverwaltung.Helper
{
  public  class fileHelper
    {
        public static string EntwicklungsPfadHelper(string pfad)
        {
            string bereinigt = pfad;

            // Switch für die Entwicklungsumgebung, 
            // .. die ist nicht im Firmennetzt deshalb funktionieren nur nackte IPs
            if (Directory.Exists(@"\\PRINTUMSERVER\99-Vorlagen"))
            {
                // alles gut;
            }
            else
            {
                bereinigt = pfad.Replace("PRINTUMSERVER", "192.168.26.250");
            }

            return bereinigt;
        }



        public static string replaceInvalidChars(string path)
        {

            string bereinigt = path;

            var invalidPathChars = path.Where(Path.GetInvalidPathChars().Contains).ToArray();
            if (invalidPathChars.Length > 0)
            {
                //  Console.WriteLine("invalid path chars: " + string.Join(string.Empty, invalidPathChars));

                foreach (var item in invalidPathChars)
                {
                    bereinigt = bereinigt.Replace(item, '_');
                }
            }


            return bereinigt;
        }

    }
}
