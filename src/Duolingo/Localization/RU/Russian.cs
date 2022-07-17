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

            { DELC.Empty_Email_Username, "Адрес электронной почты или имя пользователя не могут быть пустыми!" },
            { DELC.Empty_Password, "Пароль не может быть пустым!" },
            { DELC.Space_Username, "Имя пользователя не может содержать пробелы!" },
            { DELC.Space_Email, "Электронная почта не может содержать символы пробела!" },
            { DELC.Not_Valid_Email, "Неправильный формат электронной почты!" },
            { DELC.Only_Email_Username, "Просто введите свой адрес электронной почты или имя пользователя!" },

            { DELC.Not_Valid_User_Agent, "Неправильный формат агента пользователя!" },

            { DELC.User_Does_Not_Exist, "Пользователь не найден!" },
            { DELC.Invalid_Password, "Информация о пароле неверна!" },
            { DELC.Unknown_Failure, "Произошла неизвестная неисправность." },
            { DELC.Result_Failure, "Во время получения ответа произошел сбой." },

            { DELC.Connect_Try_Failure, "Попытка подключения не удалась." },
            { DELC.Connect_Unknown_Failure, "При установлении соединения произошла неизвестная неисправность:" },

            { DELC.Json_Convert_Deserialize_Data, "Произошел сбой при синтаксическом анализе данных." },
            { DELC.Json_Convert_Deserialize_User_Data, "Произошел сбой при синтаксическом анализе пользовательских данных." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "Произошел сбой при синтаксическом анализе словарных данных." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "Произошел сбой при разборе слова data." }
        };

        #endregion
    }

    #endregion
}