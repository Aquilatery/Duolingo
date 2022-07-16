#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DVC = Duolingo.Value.Constant;
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
    internal class Variable
    {
        #region Variable

        /// <summary>
        /// 
        /// </summary>
        public static DELL SelectLanguage = DVC.DefaultLanguage;

        #endregion
    }

    #endregion
}