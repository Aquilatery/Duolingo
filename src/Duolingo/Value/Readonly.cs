#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DSA = Duolingo.Struct.Account;
using SCG = System.Collections.Generic;
using SE = System.Exception;
using SU = System.Uri;

#endregion

namespace Duolingo.Value
{
    #region Value

    /// <summary>
    /// 
    /// </summary>
    internal class Readonly
    {
        #region Readonly

        /// <summary>
        /// 
        /// </summary>
        public static readonly SU baseUri = new("https://www.duolingo.com/");

        #endregion
    }

    #endregion
}