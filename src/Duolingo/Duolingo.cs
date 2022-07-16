#region Imports

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DHEC = Duolingo.Helper.Exception.Check;
using DHIPC = Duolingo.Helper.InternetProtocol.Client;
using DHLM = Duolingo.Helper.Localization.Message;
using DMLD = Duolingo.Model.LoginData;
using DMU = Duolingo.Model.User;
using DMUR = Duolingo.Model.User.Root;
using DSA = Duolingo.Struct.Account;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;
using NJLJO = Newtonsoft.Json.Linq.JObject;
using SC = System.Convert;
using SE = System.Exception;
using SIOMS = System.IO.MemoryStream;
using SLE = System.Linq.Enumerable;
using STE = System.Text.Encoding;
using STRER = System.Text.RegularExpressions.Regex;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 15.Jul.2022
//     Changed: 15.Jul.2022
//     Version: 1.0.0.2
//
// |---------DO-NOT-REMOVE---------|

namespace Duolingo
{
    #region Core

    /// <summary>
    /// 
    /// </summary>
    internal class Core
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<DMLD> LoginAsync()
        {
            try
            {
                ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = DHIPC.HTTPClient.GetAsync("/").ConfigureAwait(false);

                (await configuredTaskAwaitable).EnsureSuccessStatusCode();

                configuredTaskAwaitable = DHIPC.HTTPClient.PostAsync(DVR.LoginUri, new StringContent(string.Format(DVC.LoginContent, string.IsNullOrEmpty(DVV.Account.Email) ? DVV.Account.Username : DVV.Account.Email, DVV.Account.Password), DVV.EncodingType, DVC.MediaType)).ConfigureAwait(false);

                HttpResponseMessage httpResponseMessage = await configuredTaskAwaitable;

                httpResponseMessage.EnsureSuccessStatusCode();

                string Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                try
                {
                    return JsonConvert.DeserializeObject<DMLD>(Data);
                }
                catch
                {
                    throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_Data));
                }
            }
            catch (HttpRequestException)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        public static async Task GetUserDataAsync(DMLD LoginData)
        {
            try
            {
                HttpResponseMessage httpResponseMessage = await DHIPC.HTTPClient.GetAsync(string.Format(DVR.UserDataUri, LoginData.Username)).ConfigureAwait(false);

                httpResponseMessage.EnsureSuccessStatusCode();

                string Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                try
                {
                    DVV.UserData = JsonConvert.DeserializeObject<DMUR>(Data);

                    DVV.UserData.LanguageData = NJLJO.Parse(Data)[DVC.LanguageData][DVV.UserData.LearningLanguage].ToObject<DMU.LanguageStudied>();
                }
                catch
                {
                    throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_User_Data));
                }
            }
            catch (HttpRequestException)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }
        }
    }

    #endregion

    #region Duolingo

    public class Duolingo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Account"></param>
        public Duolingo(DSA Account)
        {
            DHEC.Conrol(new DSL() { Language = DVC.DefaultLanguage });
            DHEC.Conrol(Account);
            DHEC.Conrol(new DSC() { ProtocolType = DVC.DefaultProtocolType, EncodingType = DVC.DefaultEncodingType });

            Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Localization"></param>
        public Duolingo(DSL Localization, DSA Account)
        {
            DHEC.Conrol(Localization);
            DHEC.Conrol(Account);
            DHEC.Conrol(new DSC() { ProtocolType = DVC.DefaultProtocolType, EncodingType = DVC.DefaultEncodingType });

            Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Localization"></param>
        /// <param name="Account"></param>
        /// <param name="Client"></param>
        public Duolingo(DSL Localization, DSA Account, DSC Client)
        {
            DHEC.Conrol(Localization);
            DHEC.Conrol(Account);
            DHEC.Conrol(Client);

            Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Initialize()
        {
            DVV.LoginData = Core.LoginAsync().GetAwaiter().GetResult();

            DHEC.Conrol(DVV.LoginData);

            Core.GetUserDataAsync(DVV.LoginData).GetAwaiter().GetResult();
        }

        public DSA Account => DVV.Account;

        public DMLD LoginData => DVV.LoginData;

        public DMUR UserDataRaw()
        {
            return DVV.UserData;
        }

        #endregion
    }
}