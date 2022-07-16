#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DHEC = Duolingo.Helper.Exception.Check;
using DHIPC = Duolingo.Helper.InternetProtocol.Client;
using DHLM = Duolingo.Helper.Localization.Message;
using DMLD = Duolingo.Model.LoginData;
using DMLR = Duolingo.Model.Lexeme.Root;
using DMS = Duolingo.Model.Streak;
using DMU = Duolingo.Model.User;
using DMUC = Duolingo.Model.User.Calendar;
using DMUI = Duolingo.Model.UserInfo;
using DMUL = Duolingo.Model.User.Language;
using DMUPRD = Duolingo.Model.User.PointsRankingData;
using DMUR = Duolingo.Model.User.Root;
using DMUS = Duolingo.Model.User.Skill;
using DMVR = Duolingo.Model.Vocabulary.Root;
using DSA = Duolingo.Struct.Account;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;
using NJJC = Newtonsoft.Json.JsonConvert;
using NJLJO = Newtonsoft.Json.Linq.JObject;
using SCG = System.Collections.Generic;
using SCGLS = System.Collections.Generic.List<string>;
using SE = System.Exception;
using SNHHRE = System.Net.Http.HttpRequestException;
using SNHHRM = System.Net.Http.HttpResponseMessage;
using SNHSC = System.Net.Http.StringContent;
using SRCSCTAHRM = System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Net.Http.HttpResponseMessage>;
using STT = System.Threading.Tasks;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 15.Jul.2022
//     Changed: 16.Jul.2022
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
        /// <exception cref="SE"></exception>
        public static async STT.Task<DMLD> LoginAsync()
        {
            string Data;

            try
            {
                SRCSCTAHRM configuredTaskAwaitable = DHIPC.HTTPClient.GetAsync("/").ConfigureAwait(false);

                (await configuredTaskAwaitable).EnsureSuccessStatusCode();

                configuredTaskAwaitable = DHIPC.HTTPClient.PostAsync(DVR.LoginUri, new SNHSC(string.Format(DVC.LoginContent, string.IsNullOrEmpty(DVV.Account.Email) ? DVV.Account.Username : DVV.Account.Email, DVV.Account.Password), DVV.EncodingType, DVC.MediaType)).ConfigureAwait(false);

                SNHHRM httpResponseMessage = await configuredTaskAwaitable;

                httpResponseMessage.EnsureSuccessStatusCode();

                Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (SNHHRE)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }

            try
            {
                return NJJC.DeserializeObject<DMLD>(Data);
            }
            catch
            {
                throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_Data));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static async STT.Task GetUserDataAsync(DMLD LoginData)
        {
            string Data;

            try
            {
                SNHHRM httpResponseMessage = await DHIPC.HTTPClient.GetAsync(string.Format(DVR.UserDataUri, LoginData.Username)).ConfigureAwait(false);

                httpResponseMessage.EnsureSuccessStatusCode();

                Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (SNHHRE)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }

            try
            {
                DVV.UserData = NJJC.DeserializeObject<DMUR>(Data);

                DVV.UserData.LanguageData = NJLJO.Parse(Data)[DVC.LanguageData][DVV.UserData.LearningLanguage].ToObject<DMU.LanguageStudied>();
            }
            catch
            {
                throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_User_Data));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LexemeID"></param>
        /// <param name="LanguageID"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static async STT.Task<DMLR> GetLexemeDataAsync(string LexemeID, string LanguageID)
        {
            string Data;

            try
            {
                DMLR Root = new();

                SNHHRM httpResponseMessage = await DHIPC.HTTPClient.GetAsync(string.Format(DVC.LexemeContent, LexemeID, LanguageID)).ConfigureAwait(false);

                httpResponseMessage.EnsureSuccessStatusCode();

                Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (SNHHRE)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }

            try
            {
                return NJJC.DeserializeObject<DMLR>(Data);
            }
            catch
            {
                throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_Lexeme_Data));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static async STT.Task<DMVR> GetVocabularyAsync()
        {
            string Data;

            try
            {
                DMVR Root = new();

                SNHHRM httpResponseMessage = await DHIPC.HTTPClient.GetAsync(DVR.VocabularyUri).ConfigureAwait(false);

                httpResponseMessage.EnsureSuccessStatusCode();

                Data = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (SNHHRE)
            {
                throw new SE(DHLM.Get(DELC.Connect_Try_Failure));
            }
            catch (SE Exception)
            {
                throw new SE(DHLM.Get(DELC.Connect_Unknown_Failure) + "\n" + Exception.Message);
            }

            try
            {
                return NJJC.DeserializeObject<DMVR>(Data);
            }
            catch
            {
                throw new SE(DHLM.Get(DELC.Json_Convert_Deserialize_Vocabulary_Data));
            }
        }
    }

    #endregion

    #region Duolingo

    /// <summary>
    /// 
    /// </summary>
    public class Duolingo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Account"></param>
        public Duolingo(DSA Account)
        {
            DHEC.Conrol(DVR.DefaultLocalization);
            DHEC.Conrol(Account);
            DHEC.Conrol(DVR.DefaultClient);

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
            DHEC.Conrol(DVR.DefaultClient);

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
        public DSA Account => DVV.Account;

        /// <summary>
        /// 
        /// </summary>
        public DMLD LoginData => DVV.LoginData;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DMUR UserDataRaw()
        {
            return DVV.UserData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DMUI UserInfo()
        {
            return new()
            {
                Avatar = DVV.UserData.Avatar,
                Bio = DVV.UserData.Bio,
                BrowserLanguage = DVV.UserData.BrowserLanguage,
                Created = DVV.UserData.Created,
                Email = DVV.UserData.Email,
                FacebookId = DVV.UserData.FacebookId,
                Fullname = DVV.UserData.Fullname,
                GplusId = DVV.UserData.GplusId,
                Id = DVV.UserData.Id,
                InviteUrl = DVV.UserData.InviteUrl,
                IsAdmin = DVV.UserData.Admin,
                IsTrialAccount = DVV.UserData.TrialAccount,
                LearningLanguage = DVV.UserData.LearningLanguageString,
                LearningLanguageAbbreviation = DVV.UserData.LearningLanguage,
                Location = DVV.UserData.Location,
                Timezone = DVV.UserData.Timezone,
                TwitterId = DVV.UserData.TwitterId,
                UiLanguage = DVV.UserData.UiLanguage,
                Username = DVV.UserData.Username
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DMS Streak()
        {
            return new()
            {
                DailyGoal = DVV.UserData.DailyGoal,
                SiteStreak = DVV.UserData.SiteStreak,
                StreakExtendedToday = DVV.UserData.StreakExtendedToday
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SCG.List<DMUC> Calendar()
        {
            SCG.List<DMUC> Calendars = new();

            foreach (DMUC Calendar in DVV.UserData.LanguageData.Calendar)
            {
                Calendars.Add(Calendar);
            }

            return Calendars;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SCG.List<DMUPRD> Friends()
        {
            SCG.List<DMUPRD> Friends = new();

            if (DVV.UserData.LanguageData.PointsRankingData != null && DVV.UserData.LanguageData.PointsRankingData.Count > 0)
            {
                foreach (DMUPRD PointsRankingData in DVV.UserData.LanguageData.PointsRankingData)
                {
                    if (PointsRankingData.Username != DVV.UserData.Username)
                    {
                        Friends.Add(PointsRankingData);
                    }
                }
            }

            return Friends;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SCG.List<DMUL> LearningLanguages()
        {
            SCG.List<DMUL> Languages = new();

            if (DVV.UserData.Languages != null && DVV.UserData.Languages.Count > 0)
            {
                foreach (DMUL Language in DVV.UserData.Languages)
                {
                    if (Language.CurrentLearning)
                    {
                        Languages.Add(Language);
                    }
                }
            }

            return Languages;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SCGLS KnownWords()
        {
            SCGLS KnownWords = new();

            if (LearnedSkills() != null && LearnedSkills().Count > 0)
            {
                foreach (DMUS LearnedSkill in LearnedSkills())
                {
                    if (LearnedSkill.Words != null && LearnedSkill.Words.Count > 0)
                    {
                        foreach (string Word in LearnedSkill.Words)
                        {
                            KnownWords.Add(Word);
                        }
                    }
                }
            }

            return KnownWords;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SCG.List<DMUS> LearnedSkills()
        {
            SCG.List<DMUS> LearnedSkills = new();

            if (DVV.UserData.LanguageData.Skills != null && DVV.UserData.LanguageData.Skills.Count > 0)
            {
                foreach (DMUS Skill in DVV.UserData.LanguageData.Skills)
                {
                    if (Skill.Learned)
                    {
                        LearnedSkills.Add(Skill);
                    }
                }
            }

            return LearnedSkills;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LexemeID"></param>
        /// <param name="LanguageID"></param>
        /// <returns></returns>
        private async STT.Task<DMLR> LexemeDataAsync(string LexemeID, string LanguageID = "en")
        {
            return await Core.GetLexemeDataAsync(LexemeID, LanguageID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async STT.Task<DMVR> VocabularyAsync()
        {
            return await Core.GetVocabularyAsync();
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
    }

    #endregion
}