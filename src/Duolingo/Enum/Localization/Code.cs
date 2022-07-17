namespace Duolingo.Enum.Localization
{
    #region Code

    /// <summary>
    /// List of message codes of supported languages.
    /// </summary>
    public enum Code
    {
        /// <summary>
        /// Empty message code.
        /// </summary>
        Empty,


        /// <summary>
        /// Empty email alert message code.
        /// </summary>
        Empty_Email_Username,

        /// <summary>
        /// Empty password alert message code.
        /// </summary>
        Empty_Password,

        /// <summary>
        /// There is a space in the username alert message code.
        /// </summary>
        Space_Username,

        /// <summary>
        /// There is a space in the email alert message code.
        /// </summary>
        Space_Email,

        /// <summary>
        /// Email format incorrect alert message code.
        /// </summary>
        Not_Valid_Email,

        /// <summary>
        /// Just enter email or username alert message code.
        /// </summary>
        Only_Email_Username,


        /// <summary>
        /// UserAgent format incorrect alert message code.
        /// </summary>
        Not_Valid_User_Agent,


        /// <summary>
        /// User not found alert message code.
        /// </summary>
        User_Does_Not_Exist,

        /// <summary>
        /// Password incorrect alert message code.
        /// </summary>
        Invalid_Password,

        /// <summary>
        /// Unknown failure alert message code.
        /// </summary>
        Unknown_Failure,

        /// <summary>
        /// Result failure alert message code.
        /// </summary>
        Result_Failure,


        /// <summary>
        /// Error occurred in connection alert message code.
        /// </summary>
        Connect_Try_Failure,

        /// <summary>
        /// An unknown error occurred in the connection alert message code.
        /// </summary>
        Connect_Unknown_Failure,


        /// <summary>
        /// An error occurred while converting data alert message code.
        /// </summary>
        Json_Convert_Deserialize_Data,

        /// <summary>
        /// An error occurred while converting user data alert message code.
        /// </summary>
        Json_Convert_Deserialize_User_Data,

        /// <summary>
        /// An error occurred while converting lexeme data alert message code.
        /// </summary>
        Json_Convert_Deserialize_Lexeme_Data,

        /// <summary>
        /// An error occurred while converting vocabulary data alert message code.
        /// </summary>
        Json_Convert_Deserialize_Vocabulary_Data,

    }

    #endregion
}