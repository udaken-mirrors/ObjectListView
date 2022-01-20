using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListViewPrinterDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if NET6_0_OR_GREATER
            ApplicationConfiguration.Initialize();
#else
#if NET5_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#endif
            Application.Run(new Form1());
        }
    }
}