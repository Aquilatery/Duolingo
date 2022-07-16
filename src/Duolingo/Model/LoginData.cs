#region Imports

using NJJPA = Newtonsoft.Json.JsonPropertyAttribute;

#endregion

namespace Duolingo.Model
{
    #region LoginData

    /// <summary>
    /// Model login data class.
    /// </summary>
    public class LoginData
    {
        /// <summary>
        /// 
        /// </summary>
        [NJJPA("response")]
        internal string Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NJJPA("username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NJJPA("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NJJPA("failure")]
        internal string Failure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NJJPA("message")]
        internal string Message { get; set; }
    }

    #endregion
}
