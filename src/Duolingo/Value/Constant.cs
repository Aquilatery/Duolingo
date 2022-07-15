#region Imports

using DSA = Duolingo.Struct.Account;
using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using SCG = System.Collections.Generic;
using SE = System.Exception;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using SU = System.Uri;

#endregion

namespace Duolingo.Value
{
    #region Value

    /// <summary>
    /// 
    /// </summary>
    internal class Constant
    {
        #region Constant

        /// <summary>
        /// 
        /// </summary>
        public static readonly SU baseUri = new("https://www.duolingo.com/");

        /// <summary>
        /// 
        /// </summary>
        public const string NotSetMessage = "The messages of the selected language are not set.";

        #endregion
    }

    #endregion
}