using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrintumProjektverwaltung.Helper
{
    class TextHelper
    {
        internal static bool checkPhoneNr(string txt)
        {
            string vorKlammer;
            string inKlammer;
            string nachKlammer;
            string ohneLeerstellen;
           string text = txt.Trim();

            // muss mit + beginnen
            if (text.StartsWith("+") == false)
            {
                return false;
            }

            int klammerauf = text.IndexOf('(');
            int klammerzu = text.IndexOf(')');

            if (klammerauf > 0 && klammerzu > 0 && klammerzu > klammerauf)
            {
                vorKlammer = text.Substring(1, klammerauf - 1).Trim();
                if (hatNurZahlen(vorKlammer) == false)
                {
                    return false;
                }


                inKlammer = text.Substring(klammerauf + 1, klammerzu - 1 - klammerauf).Trim();
                if (hatNurZahlen(inKlammer) == false)
                {
                    return false;
                }


                nachKlammer = text.Substring(klammerzu + 1, text.Length - 1 - klammerzu).Trim();
                ohneLeerstellen = nachKlammer.Replace(" ", "");
                if (hatNurZahlen(ohneLeerstellen) == false)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



            return true;
        }

        private static bool hatNurZahlen(string txt)
        {
            Regex reg = new Regex(@"^[0-9]+$");

            if (reg.IsMatch(txt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
