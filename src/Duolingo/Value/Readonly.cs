#region Imports

using DELL = Duolingo.Enum.Language.Languages;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using DVC = Duolingo.Value.Constant;
using SCG = System.Collections.Generic;
using SNHHC = System.Net.Http.HttpClient;
using STE = System.Text.Encoding;
using SU = System.Uri;

#endregion

namespace Duolingo.Value
{
    #region Value

    /// <summary>
    /// Value readonly.
    /// </summary>
    internal class Readonly
    {
        #region Readonly

        /// <summary>
        /// 
        /// </summary>
        public static readonly SNHHC HttpClient = new();

        /// <summary>
        /// 
        /// </summary>
        public static readonly SU BaseUri = new("https://www.duolingo.com/");

        /// <summary>
        /// 
        /// </summary>
        public static readonly string LoginUri = "login";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string UserDataUri = "users/{0}";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string VocabularyUri = "vocabulary/overview";

        /// <summary>
        /// 
        /// </summary>
        public static readonly STE DefaultEncodingType = STE.UTF8;

        /// <summary>
        /// 
        /// </summary>
        public static readonly DSL DefaultLocalization = new()
        {
            Language = DVC.DefaultLanguage
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly DSC DefaultClient = new()
        {
#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

            ProtocolType = DVC.DefaultProtocolType,

#endif
            Timeout = DVC.DefaultTimeout,
            UserAgent = DVC.DefaultUserAgent,
            EncodingType = DefaultEncodingType
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly SCG.Dictionary<DELL, string> NotSetCode = new()
        {
            { DELL.TR, "Seçilen kodun mesajı ayarlanmadı." },
            { DELL.EN, "The message of the selected code is not set." },
            { DELL.DE, "Die Meldung des ausgewählten Codes ist nicht festgelegt." },
            { DELL.ES, "El mensaje del código seleccionado no está establecido." },
            { DELL.RU, "Сообщение выбранного кода не задано." }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly SCG.Dictionary<DELL, string> NotSetMessage = new()
        {
            { DELL.TR, "Türkçe dilinin mesajları ayarlanmadı." },
            { DELL.EN, "Messages of the English language are not set." },
            { DELL.DE, "Nachrichten der Deutschen sprache werden nicht gesetzt." },
            { DELL.ES, "Los mensajes del idioma Español no están configurados." },
            { DELL.RU, "Сообщения на Русском языке не устанавливаются." }
        };

        #endregion
    }

    #endregion
}