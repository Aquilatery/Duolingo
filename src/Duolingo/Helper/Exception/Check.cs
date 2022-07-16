#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DHLM = Duolingo.Helper.Localization.Message;
using DLCMC = Duolingo.Localization.CUSTOM.Custom;
using DSA = Duolingo.Struct.Account;
using DSL = Duolingo.Struct.Localization;
using DVV = Duolingo.Value.Variable;
using DVC = Duolingo.Value.Constant;
using SCG = System.Collections.Generic;
using SE = System.Exception;

#endregion

namespace Duolingo.Helper.Exception
{
    #region Check

    /// <summary>
    /// 
    /// </summary>
    internal class Check
    {
        #region Control

        /// <summary>
        /// 
        /// </summary>
        public static bool Conrol(DSL Localization)
        {
            DVV.SelectLanguage = Localization.Language;

            if (Localization.Messages != null)
            {
                DVV.SelectLanguage = DELL.CUSTOM;
                DLCMC.Messages = Localization.Messages;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Conrol(DSA Account)
        {
            if (string.IsNullOrEmpty(Account.Email) && string.IsNullOrEmpty(Account.Username))
            {
                throw new SE(DHLM.Get(DELC.Empty_Email_Username));
            }

            if (!string.IsNullOrEmpty(Account.Email) && string.IsNullOrWhiteSpace(Account.Email))
            {
                throw new SE(DHLM.Get(DELC.Space_Email));
            }

            if (!string.IsNullOrEmpty(Account.Username) && string.IsNullOrWhiteSpace(Account.Username))
            {
                throw new SE(DHLM.Get(DELC.Space_Username));
            }

            if (string.IsNullOrEmpty(Account.Password))
            {
                throw new SE(DHLM.Get(DELC.Empty_Password));
            }

            return true;
        }

        #endregion
    }

    #endregion
}