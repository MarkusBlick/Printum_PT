﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintumProjektverwaltung
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// sollte jetzt auch in github erscheinen
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Form1_main());
        }
    }
}
