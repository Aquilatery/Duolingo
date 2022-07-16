#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DHLM = Duolingo.Helper.Localization.Message;
using DLCMC = Duolingo.Localization.CM.Custom;
using DSA = Duolingo.Struct.Account;
using DSL = Duolingo.Struct.Localization;
using DVV = Duolingo.Value.Variable;
using DVC = Duolingo.Value.Constant;
using SCG = System.Collections.Generic;
using SE = System.Exception;
using System.Text.RegularExpressions;

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

            if (DVV.SelectLanguage == DELL.CM && Localization.Messages == null)
            {
                //DVV.SelectLanguage = DVC.DefaultLanguage;
                //throw new SE("Messages are not set even though a custom language is selected!");
            }

            if (Localization.Messages != null)
            {
                DVV.SelectLanguage = DELL.CM;
                DLCMC.Messages = Localization.Messages;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Conrol(DSA Account)
        {
            if (!string.IsNullOrEmpty(Account.Email) && !string.IsNullOrEmpty(Account.Username))
            {
                throw new SE(DHLM.Get(DELC.Only_Email_Username));
            }

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

            if (!Regex.IsMatch(Account.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
            {
                throw new SE(DHLM.Get(DELC.Not_Valid_Email));
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