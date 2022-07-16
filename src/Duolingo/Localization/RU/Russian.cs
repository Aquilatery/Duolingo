#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.RU
{
    #region Russian

    /// <summary>
    /// Localization russian message class.
    /// </summary>
    internal class Russian
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Пустой" },

            { DELC.Empty_Email_Username, "Электронная почта или имя пользователя не могут быть пустыми!" },
            { DELC.Empty_Password, "Пароль не может быть пустым!" },
            { DELC.Space_Username, "Имя пользователя не может содержать пробелы!" },
            { DELC.Space_Email, "Электронная почта не может содержать пробелов!" },
            { DELC.Not_Valid_Email, "Неверный формат электронной почты!" },
            { DELC.Only_Email_Username, "Просто введите адрес электронной почты или имя пользователя!" },


            { DELC.User_Does_Not_Exist, "Пользователь не найден!" },
            { DELC.Invalid_Password, "Информация о пароле неверна!" },
            { DELC.Unknown_Failure, "Произошла неизвестная ошибка." },
            { DELC.Result_Failure, "При подключении произошел сбой." },

            { DELC.Connect_Try_Failure, "Попытка подключения не удалась." },
            { DELC.Connect_Unknown_Failure, "При подключении произошла неизвестная ошибка:" },

            { DELC.Json_Convert_Deserialize_Data, "Произошла ошибка при синтаксическом анализе данных." },
            { DELC.Json_Convert_Deserialize_User_Data, "Произошла ошибка при синтаксическом анализе пользовательских данных»." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "Произошла ошибка при синтаксическом анализе данных словаря»." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "Произошла ошибка при синтаксическом анализе данных слова»." }
        };

        #endregion
    }

    #endregion
}