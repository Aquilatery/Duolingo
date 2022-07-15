#region Imports

using SC = System.Convert;
using SIOMS = System.IO.MemoryStream;
using SLE = System.Linq.Enumerable;
using STE = System.Text.Encoding;
using STRER = System.Text.RegularExpressions.Regex;
using DSA = Duolingo.Struct.Account;
using DSL = Duolingo.Struct.Localization;
using DHEC = Duolingo.Helper.Exception.Check;
using DVC = Duolingo.Value.Constant;


using System.Net.Http;
using System;

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

    }

    #endregion

    #region Duolingo

    public class Duolingo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Localization"></param>
        public Duolingo(DSL Localization, DSA Account)
        {
            DHEC.Conrol(Localization);
            DHEC.Conrol(Account);
        }

        #endregion
    }
}