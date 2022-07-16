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
        public static readonly SCG.Dictionary<DELL, string> NotSetCode = new()
        {
            { DELL.TR, "Seçilen kodun mesajı ayarlanmadı." },
            { DELL.EN, "The message of the selected code is not set." },
            { DELL.ES, "El mensaje del código seleccionado no está configurado." },
            { DELL.RU, "Сообщение о выбранном коде не установлено." }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly SCG.Dictionary<DELL, string> NotSetMessage = new()
        {
            { DELL.TR, "Türkçe dilinin mesajları ayarlanmadı." },
            { DELL.EN, "Messages of the English language are not set." },
            { DELL.ES, "Los mensajes del idioma Español no están configurados." },
            { DELL.RU, "Сообщения Pусского языка не устанавливаются." }
        };

        #endregion
    }

    #endregion
}