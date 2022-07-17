#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.DE
{
    #region German

    /// <summary>
    /// Localization german message class.
    /// </summary>
    internal class German
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Leer" },

            { DELC.Empty_Email_Username, "E-Mail-Adresse oder Benutzername dürfen nicht leer sein!" },
            { DELC.Empty_Password, "Das Passwort darf nicht leer sein!" },
            { DELC.Space_Username, "Der Benutzername darf keine Leerzeichen enthalten!" },
            { DELC.Space_Email, "E-Mail darf keine Leerzeichen enthalten!" },
            { DELC.Not_Valid_Email, "Das E-Mail-Format ist falsch!" },
            { DELC.Only_Email_Username, "Geben Sie einfach Ihre E-Mail-Adresse oder Ihren Benutzernamen ein!" },

            { DELC.Not_Valid_User_Agent, "Das User-Agent-Format ist falsch!" },


            { DELC.User_Does_Not_Exist, "Benutzer nicht gefunden!" },
            { DELC.Invalid_Password, "Die Passwortinformationen sind falsch!" },
            { DELC.Unknown_Failure, "Es gab eine unbekannte Fehlfunktion." },
            { DELC.Result_Failure, "Beim Empfang der Antwort gab es eine Fehlfunktion." },

            { DELC.Connect_Try_Failure, "Der Verbindungsversuch ist fehlgeschlagen." },
            { DELC.Connect_Unknown_Failure, "Beim Herstellen der Verbindung ist eine unbekannte Fehlfunktion aufgetreten:" },

            { DELC.Json_Convert_Deserialize_Data, "Beim Analysieren von Daten ist ein Fehler aufgetreten." },
            { DELC.Json_Convert_Deserialize_User_Data, "Beim Analysieren von Benutzerdaten ist ein Fehler aufgetreten." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "Beim Analysieren von Wörterbuchdaten ist eine Fehlfunktion aufgetreten." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "Beim Analysieren des Wortes Daten ist eine Fehlfunktion aufgetreten." }
        };

        #endregion
    }

    #endregion
}