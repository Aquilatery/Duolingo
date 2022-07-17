#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DESPT = Duolingo.Enum.Security.ProtocolType;

#endif

using DELL = Duolingo.Enum.Language.Languages;

#endregion

namespace Duolingo.Value
{
    #region Value

    /// <summary>
    /// Value constant.
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
        public const int DefaultTimeout = 5;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultUserAgent = "Taiizor-Duolingo-HttpClientProduct/1.0.0.3";

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

        /// <summary>
        /// 
        /// </summary>
        public const DESPT DefaultProtocolType = DESPT.TLS12;

#endif

        /// <summary>
        /// 
        /// </summary>
        public const string MediaType = "application/json";

        /// <summary>
        /// 
        /// </summary>
        public const string LanguageData = "language_data";

        /// <summary>
        /// 
        /// </summary>
        public const string LoginContent = "{{\"login\":\"{0}\",\"password\":\"{1}\"}}";

        /// <summary>
        /// 
        /// </summary>
        public const string LexemeContent = "/api/1/dictionary_page?lexeme_id={0}&from_language_id={1}";

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