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

            { DELC.Empty_Email_Username, "Email or Username cannot be empty!" },
            { DELC.Empty_Password, "Password cannot be empty!" },
            { DELC.Space_Username, "Username cannot contain spaces!" },
            { DELC.Space_Email, "Email cannot contain spaces!" },
            { DELC.Not_Valid_Email, "Email format is incorrect!" },
            { DELC.Only_Email_Username, "Just enter your email or username!" },

            { DELC.User_Does_Not_Exist, "User not found!" },
            { DELC.Invalid_Password, "Password information is incorrect!" },
            { DELC.Unknown_Failure, "An unknown failure occurred." },
            { DELC.Result_Failure, "There was a failure while connecting." },

            { DELC.Connect_Try_Failure, "Connection attempt failed." },
            { DELC.Connect_Unknown_Failure, "An unknown failure occurred while connecting:" },

            { DELC.Json_Convert_Deserialize_Data, "There was an error parsing the data." },
            { DELC.Json_Convert_Deserialize_User_Data, "There was an error parsing user data." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "There was an error parsing the dictionary data." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "There was an error parsing the word data." }
        };

        #endregion
    }

    #endregion
}