#region Imports

using System;
using System.Globalization;
using System.Windows.Forms;

#endregion

namespace Duolingo_CR
{
    #region Program

    /// <summary>
    /// 
    /// </summary>
    internal static class Program
    {
        #region Main

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
                Application.Run(new Catcher());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        #endregion
    }

    #endregion
}