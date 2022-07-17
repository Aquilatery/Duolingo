#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.ES
{
    #region Spanish

    /// <summary>
    /// Localization spanish message class.
    /// </summary>
    internal class Spanish
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Vacío" },

            { DELC.Empty_Email_Username, "¡El correo electrónico o el nombre de usuario no pueden estar vacíos!" },
            { DELC.Empty_Password, "¡La contraseña no puede estar en blanco!" },
            { DELC.Space_Username, "¡El nombre de usuario no puede contener caracteres de espacio!" },
            { DELC.Space_Email, "¡El correo electrónico no puede contener caracteres de espacio!" },
            { DELC.Not_Valid_Email, "¡El formato del correo electrónico es incorrecto!" },
            { DELC.Only_Email_Username, "¡Simplemente ingrese su correo electrónico o nombre de usuario!" },

            { DELC.Not_Valid_User_Agent, "¡El formato useragent es incorrecto!" },

            { DELC.User_Does_Not_Exist, "¡Usuario no encontrado!" },
            { DELC.Invalid_Password, "¡La información de la contraseña es incorrecta!" },
            { DELC.Unknown_Failure, "Hubo un mal funcionamiento desconocido." },
            { DELC.Result_Failure, "Hubo un mal funcionamiento al recibir la respuesta." },

            { DELC.Connect_Try_Failure, "Error en el intento de conexión." },
            { DELC.Connect_Unknown_Failure, "Se ha producido un mal funcionamiento desconocido al realizar la conexión:" },

            { DELC.Json_Convert_Deserialize_Data, "Hubo un error al analizar los datos." },
            { DELC.Json_Convert_Deserialize_User_Data, "Hubo un error al analizar los datos del usuario." },
            { DELC.Json_Convert_Deserialize_Lexeme_Data, "Hubo un mal funcionamiento al analizar los datos del diccionario." },
            { DELC.Json_Convert_Deserialize_Vocabulary_Data, "Hubo un mal funcionamiento al analizar la palabra datos." }
        };

        #endregion
    }

    #endregion
}