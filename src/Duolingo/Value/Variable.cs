#region Imports

using Newtonsoft.Json;
using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DESPT = Duolingo.Enum.Security.ProtocolType;
using DHST = Duolingo.Helper.Security.Type;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DMLD = Duolingo.Model.LoginData;
using DMUR = Duolingo.Model.User.Root;
using DSA = Duolingo.Struct.Account;
using DVC = Duolingo.Value.Constant;
using SCG = System.Collections.Generic;
using SE = System.Exception;
using STE = System.Text.Encoding;
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

        /// <summary>
        /// 
        /// </summary>
        public static DESPT ProtocolType = DVC.DefaultProtocolType;

        /// <summary>
        /// 
        /// </summary>
        public static STE EncodingType = DVC.DefaultEncodingType;

        /// <summary>
        /// 
        /// </summary>
        public static DSA Account = new();

        /// <summary>
        /// 
        /// </summary>
        public static DMLD LoginData = new();

        /// <summary>
        /// 
        /// </summary>

        public static DMUR UserData = new();

        #endregion
    }

    #endregion
}