#region Imports

using System.Text.RegularExpressions;
using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DHIPC = Duolingo.Helper.InternetProtocol.Client;
using DHLM = Duolingo.Helper.Localization.Message;
using DLCMC = Duolingo.Localization.CM.Custom;
using DMLD = Duolingo.Model.LoginData;
using DSA = Duolingo.Struct.Account;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;
using SE = System.Exception;

#endregion

namespace Duolingo.Helper.Exception
{
    #region Check

    /// <summary>
    /// Helper exception check class.
    /// </summary>
    internal class Check
    {
        #region Control

        /// <summary>
        /// The accuracy of the account information is checked.
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
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

            if (!string.IsNullOrEmpty(Account.Email) && !Regex.IsMatch(Account.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
            {
                throw new SE(DHLM.Get(DELC.Not_Valid_Email));
            }

            if (string.IsNullOrEmpty(Account.Password))
            {
                throw new SE(DHLM.Get(DELC.Empty_Password));
            }

            DVV.Account = Account;

            return true;
        }

        /// <summary>
        /// The accuracy of client information is checked.
        /// </summary>
        /// <param name="Client"></param>
        /// <returns></returns>
        public static bool Conrol(DSC Client)
        {
#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

            DVV.ProtocolType = Client.ProtocolType;

#endif

            if (Client.Timeout <= 0)
            {
                DVV.Timeout = DVC.DefaultTimeout;
            }
            else
            {
                DVV.Timeout = Client.Timeout;
            }

            if (Client.UserAgent == null)
            {
                DVV.UserAgent = DVC.DefaultUserAgent;
            }
            else
            {
                DVV.UserAgent = Client.UserAgent;
            }

            try
            {
                DVR.HttpClient.DefaultRequestHeaders.Add("User-Agent", DVV.UserAgent);
                //DVR.HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(DVV.UserAgent);
            }
            catch
            {
                throw new SE(DHLM.Get(DELC.Not_Valid_User_Agent));
            }

            DVV.EncodingType = Client.EncodingType;

            if (DVV.Client == null)
            {
                DVV.Client = new DHIPC();
            }

            return true;
        }

        /// <summary>
        /// The accuracy of localization information is checked.
        /// </summary>
        /// <param name="Localization"></param>
        /// <returns></returns>
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
                DLCMC.Messages = Localization.Messages;
            }

            return true;
        }

        /// <summary>
        /// The accuracy of login data information is checked.
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool Conrol(DMLD LoginData)
        {
            if (LoginData == null)
            {
                throw new SE(DHLM.Get(DELC.Result_Failure));
            }

            if (LoginData.Response == null || !string.IsNullOrEmpty(LoginData.Failure))
            {
                if (LoginData.Failure == "user_does_not_exist")
                {
                    throw new SE(DHLM.Get(DELC.User_Does_Not_Exist));
                }
                else if (LoginData.Failure == "invalid_password")
                {
                    throw new SE(DHLM.Get(DELC.Invalid_Password));
                }
                else
                {
                    throw new SE(DHLM.Get(DELC.Unknown_Failure));
                }
            }

            return true;
        }

        #endregion
    }

    #endregion
}