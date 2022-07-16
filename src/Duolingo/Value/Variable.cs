#region Imports

using DELL = Duolingo.Enum.Language.Languages;
using DESPT = Duolingo.Enum.Security.ProtocolType;
using DMLD = Duolingo.Model.LoginData;
using DMUR = Duolingo.Model.User.Root;
using DSA = Duolingo.Struct.Account;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using STE = System.Text.Encoding;

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
        public static STE EncodingType = DVR.DefaultEncodingType;

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