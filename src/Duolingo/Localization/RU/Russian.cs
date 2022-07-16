#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.RU
{
    #region Russian

    /// <summary>
    /// 
    /// </summary>
    internal class Russian
    {
        #region Messages

        /// <summary>
        /// 
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Пустой" },

            { DELC.Empty_Email_Username, "Электронная почта или имя пользователя не могут быть пустыми!" },
            { DELC.Empty_Password, "Пароль не может быть пустым!" },
            { DELC.Space_Username, "Имя пользователя не может содержать пробелы!" },
            { DELC.Space_Email, "Электронная почта не может содержать пробелов!" },
        };

        #endregion
    }

    #endregion
}