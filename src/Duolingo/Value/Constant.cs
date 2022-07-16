﻿#region Imports

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
    internal class Constant
    {
        #region Constant

        /// <summary>
        /// 
        /// </summary>
        public const DELL DefaultLanguage = DELL.EN;

        /// <summary>
        /// 
        /// </summary>
        public const string NotSetCode = "The message of the selected code is not set.";

        /// <summary>
        /// 
        /// </summary>
        public const string NotSetMessage = "The messages of the selected language are not set.";

        #endregion
    }

    #endregion
}