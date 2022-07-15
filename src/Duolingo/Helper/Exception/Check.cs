#region Imports

using DSA = Duolingo.Struct.Account;
using DSL = Duolingo.Struct.Localization;
using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;
using SE = System.Exception;
using DHLM = Duolingo.Helper.Localization.Message;
using DLCMC = Duolingo.Localization.CUSTOM.Custom;

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
            if (Localization.Messages != null)
            {
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
                throw new SE("Email veya Username boş olamaz!");
            }
            
            if (!string.IsNullOrEmpty(Account.Email) && string.IsNullOrWhiteSpace(Account.Email))
            {
                throw new SE("Email boşluk karakteri içeremez!");
            }

            if (!string.IsNullOrEmpty(Account.Username) && string.IsNullOrWhiteSpace(Account.Username))
            {
                throw new SE("Username boşluk karakteri içeremez!");
            }

            if (string.IsNullOrEmpty(Account.Password))
            {
                throw new SE("Password boş olamaz!");
            }

            return true;
        }

        #endregion
    }

    #endregion
}