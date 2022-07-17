#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.EN
{
    #region English

    /// <summary>
    /// Localization english message class.
    /// </summary>
    internal class English
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Empty" },

            { DELC.Empty_Email_Username, "Email or username can't be empty!" },
            { DELC.Empty_Password, "The password cannot be empty!" },
            { DELC.Space_Username, "Username cannot contain space characters!" },
            { DELC.Space_Email, "Email cannot contain space characters!" },
            { DELC.Not_Valid_Email, "The email format is incorrect!" },
            { DELC.Only_Email_Username, "Just enter your email or username!" },

            { DELC.Not_Valid_User_Agent, "The useragent format is incorrect!" },

            { DELC.User_Does_Not_Exist, "User not found!" },
            { DELC.Invalid_Password, "The password information is incorrect!" },
            { DELC.Unknown_Failure, "There was an unknown malfunction." },
            { DELC.Result_Failure, "There was a malfunction while receiving the answer." },

            { DELC.Connect_Try_Failure, "The connection attempt failed." },
            { DELC.Connect_Unknown_Failure, "An unknown malfunction occurred while making the connection:" },

            { DELC.Json_Convert_Deserialize_Data, "There was a malfunction while parsing the data." },
            { DELC.Json_Convert_Deserialize_User_Data, "There was a malfunction while parsing the user data." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "There was a malfunction while parsing the lexeme data." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "There was a malfunction while parsing the vocabulary data." }
        };

        #endregion
    }

    #endregion
}