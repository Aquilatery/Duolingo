#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DESPT = Duolingo.Enum.Security.ProtocolType;

#endif

using DELL = Duolingo.Enum.Language.Languages;
using DHIPC = Duolingo.Helper.InternetProtocol.Client;
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
    /// Value variable.
    /// </summary>
    internal class Variable
    {
        #region Variable

        /// <summary>
        /// 
        /// </summary>
        public static DHIPC Client = null;

        /// <summary>
        /// 
        /// </summary>
        public static DELL SelectLanguage = DVC.DefaultLanguage;

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

        /// <summary>
        /// 
        /// </summary>
        public static DESPT ProtocolType = DVC.DefaultProtocolType;

#endif

        /// <summary>
        /// 
        /// </summary>
        public static int Timeout = DVC.DefaultTimeout;

        /// <summary>
        /// 
        /// </summary>
        public static string UserAgent = DVC.DefaultUserAgent;

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