#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.TR
{
    #region Turkish

    /// <summary>
    /// 
    /// </summary>
    internal class Turkish
    {
        #region Messages

        /// <summary>
        /// 
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Boş" },

            { DELC.Empty_Email_Username, "E-posta veya kullanıcı adı boş olamaz!" },
            { DELC.Empty_Password, "Şifre boş olamaz!" },
            { DELC.Space_Username, "Kullanıcı adı boşluk karakteri içeremez!" },
            { DELC.Space_Email, "E-posta boşluk karakteri içeremez!" },
        };

        #endregion
    }

    #endregion
}