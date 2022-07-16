#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.EN
{
    #region English

    /// <summary>
    /// 
    /// </summary>
    internal class English
    {
        #region Messages

        /// <summary>
        /// 
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages => new()
        {
            { DELC.Empty, "Empty" },

            { DELC.Empty_Email_Username, "Email or Username cannot be empty!" },
            { DELC.Empty_Password, "Password cannot be empty!" },
            { DELC.Space_Username, "Username cannot contain spaces!" },
            { DELC.Space_Email, "Email cannot contain spaces!" },
        };

        #endregion
    }

    #endregion
}