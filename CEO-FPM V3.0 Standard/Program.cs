using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CEO_FPM_V3._0_Standard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
