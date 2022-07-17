#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.TR
{
    #region Turkish

    /// <summary>
    /// Localization turkish message class.
    /// </summary>
    internal class Turkish
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Boş" },

            { DELC.Empty_Email_Username, "E-posta veya kullanıcı adı boş olamaz!" },
            { DELC.Empty_Password, "Şifre boş olamaz!" },
            { DELC.Space_Username, "Kullanıcı adı boşluk karakteri içeremez!" },
            { DELC.Space_Email, "E-posta boşluk karakteri içeremez!" },
            { DELC.Not_Valid_Email, "E-posta formatı hatalı!" },
            { DELC.Only_Email_Username, "Sadece e-posta veya kullanıcı adını girin!" },

            { DELC.Not_Valid_User_Agent, "UserAgent formatı hatalı!" },

            { DELC.User_Does_Not_Exist, "Kullanıcı bulunamadı!" },
            { DELC.Invalid_Password, "Şifre bilgisi hatalı!" },
            { DELC.Unknown_Failure, "Bilinmeyen bir arıza oldu." },
            { DELC.Result_Failure, "Cevap alınırken bir arıza oldu." },

            { DELC.Connect_Try_Failure, "Bağlantı denemesi başarısız oldu." },
            { DELC.Connect_Unknown_Failure, "Bağlantı yapılırken bilinmeyen bir arıza oldu:" },

            { DELC.Json_Convert_Deserialize_Data, "Veri ayrıştırılırken bir arıza oldu." },
            { DELC.Json_Convert_Deserialize_User_Data, "Kullanıcı verisi ayrıştırılırken bir arıza oldu." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "Sözlük verisi ayrıştırılırken bir arıza oldu." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "Kelime verisi ayrıştırılırken bir arıza oldu." }
        };

        #endregion
    }

    #endregion
}