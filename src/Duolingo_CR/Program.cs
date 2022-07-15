﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Duolingo_CR
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
#if NETCOREAPP3_1 || NET5_0 || NET6_0 || NET7_0
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
                CultureInfo cultureInfo = new(CultureInfo.CurrentCulture.TextInfo.CultureName);
                Application.SetCompatibleTextRenderingDefault(false);
                Application.CurrentCulture = cultureInfo;
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}