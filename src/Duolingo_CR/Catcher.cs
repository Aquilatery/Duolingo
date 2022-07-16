#region Imports

using DD = Duolingo.Duolingo;
using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DESPT = Duolingo.Enum.Security.ProtocolType;
using DSA = Duolingo.Struct.Account;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using NJJS = Newtonsoft.Json.JsonConvert;
using STE = System.Text.Encoding;
using SWFF = System.Windows.Forms.Form;
using SWFMB = System.Windows.Forms.MessageBox;
using SE = System.Exception;
using SEA = System.EventArgs;

#endregion

namespace Duolingo_CR
{
    #region Catcher

    /// <summary>
    /// 
    /// </summary>
    public partial class Catcher : SWFF
    {
        #region Catcher

        /// <summary>
        /// 
        /// </summary>
        public Catcher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, SEA e)
        {
            /// <summary>
            /// 
            /// </summary>
            DSL Localization = new()
            {
                Language = DELL.EN, //DELL.CM
                Messages = new()
                {
                    { DELC.Empty, "x" },

                    { DELC.Empty_Email_Username, "xx!" },
                    { DELC.Empty_Password, "xxx!" },
                    { DELC.Space_Username, "xxxx!" },
                    { DELC.Space_Email, "xxxxx!" },
                    { DELC.Not_Valid_Email, "xxxxxx!" },
                    { DELC.Only_Email_Username, "xxxxxxx!" },

                    { DELC.User_Does_Not_Exist, "xxxxxxxx!" },
                    { DELC.Invalid_Password, "xxxxxxxxx!" },
                    { DELC.Unknown_Failure, "xxxxxxxxxx." },
                    { DELC.Result_Failure, "xxxxxxxxxxx." },

                    { DELC.Connect_Try_Failure, "xxxxxxxxxxxx." },
                    { DELC.Connect_Unknown_Failure, "xxxxxxxxxxxxx:" },

                    { DELC.Json_Convert_Deserialize_Data, "xxxxxxxxxxxxxx." },
                    { DELC.Json_Convert_Deserialize_User_Data, "xxxxxxxxxxxxxxx." },
                    { DELC.Json_Convert_Deserialize_Lexeme_Data, "xxxxxxxxxxxxxxxx." },
                    { DELC.Json_Convert_Deserialize_Vocabulary_Data, "xxxxxxxxxxxxxxxxs." }
                }
            };

            /// <summary>
            /// 
            /// </summary>
            DSA Account = new()
            {
                Email = Email.Text,
                Username = Username.Text,
                Password = Password.Text
            };

            /// <summary>
            /// 
            /// </summary>
            DSC Client = new()
            {
                ProtocolType = DESPT.TLS12,
                EncodingType = STE.UTF8
            };

            
            try
            {
                /// <summary>
                /// 
                /// </summary>
                DD DuoAPI = new(Localization, Account, Client);

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(DuoAPI.LoginData.UserId + " - " + DuoAPI.LoginData.Username);

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(DuoAPI.UserDataRaw().InviteUrl);

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.UserInfo(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.Streak(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.Calendar(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.Friends(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.LearningLanguages(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.KnownWords(), Newtonsoft.Json.Formatting.None));

                /// <summary>
                /// 
                /// </summary>
                SWFMB.Show(NJJS.SerializeObject(DuoAPI.LearnedSkills(), Newtonsoft.Json.Formatting.None));

                /// <summary>
                /// 
                /// </summary>
                //SWFMB.Show(NJJS.SerializeObject(DuoAPI.VocabularyAsync(), Newtonsoft.Json.Formatting.Indented));

                /// <summary>
                /// 
                /// </summary>
                //SWFMB.Show(NJJS.SerializeObject(DuoAPI.LexemeDataAsync("55", "en"), Newtonsoft.Json.Formatting.Indented));
            }
            catch (SE Exception)
            {
                SWFMB.Show(Exception.Message);
                //SWFMB.Show(Exception.StackTrace);
            }
        }

        #endregion
    }

    #endregion
}