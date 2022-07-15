#region Imports

using SC = System.Convert;
using SIOMS = System.IO.MemoryStream;
using SLE = System.Linq.Enumerable;
using STE = System.Text.Encoding;
using STRER = System.Text.RegularExpressions.Regex;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 15.Jul.2022
//     Changed: 15.Jul.2022
//     Version: 1.0.0.2
//
// |---------DO-NOT-REMOVE---------|

namespace Duolingo
{
    #region Core

    /// <summary>
    /// 
    /// </summary>
    internal class Core
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static bool Empty(string Text = "Null")
        {
            return Text == "Null";
        }
    }

    #endregion
}