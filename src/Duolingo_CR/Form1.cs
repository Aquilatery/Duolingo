#region Imports

using DD = Duolingo.Duolingo;
using DELL = Duolingo.Enum.Language.Languages;
using DESPT = Duolingo.Enum.Security.ProtocolType;
using DMLD = Duolingo.Model.LoginData;
using DSA = Duolingo.Struct.Account;
using DSC = Duolingo.Struct.Client;
using DSL = Duolingo.Struct.Localization;
using NJJS = Newtonsoft.Json.JsonConvert;
using STE = System.Text.Encoding;
using SWFF = System.Windows.Forms.Form;
using SWFMB = System.Windows.Forms.MessageBox;

#endregion

namespace Duolingo_CR
{
    public partial class Form1 : SWFF
    {
        public Form1()
        {
            InitializeComponent();

            DSL Localization = new()
            {
                Language = DELL.TR,
                //Messages = new()
                //{
                //    { Code.Empty, "x" },

                //    { Code.Empty_Email_Username, "xx!" },
                //    { Code.Empty_Password, "xxx!" },
                //    { Code.Space_Username, "xxxx!" },
                //    { Code.Space_Email, "xxxxx!" },
                //}
            };

            DSA Account = new()
            {
                Email = "alyaxvega@gmail.com", //alyaxvega@gmail.com
                Username = "", //AlyaVega
                Password = "123qWe123"
            };

            DSC Client = new()
            {
                ProtocolType = DESPT.TLS12,
                EncodingType = STE.UTF8
            };

            DD DuoAPI = new(Localization, Account, Client);

            DMLD LoginData = DuoAPI.LoginData;

            SWFMB.Show(LoginData.UserId + " - " + LoginData.Username);

            SWFMB.Show(DuoAPI.UserDataRaw().InviteUrl);

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.UserInfo(), Newtonsoft.Json.Formatting.Indented));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.Streak(), Newtonsoft.Json.Formatting.Indented));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.Calendar(), Newtonsoft.Json.Formatting.Indented));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.Friends(), Newtonsoft.Json.Formatting.Indented));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.LearningLanguages(), Newtonsoft.Json.Formatting.Indented));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.KnownWords(), Newtonsoft.Json.Formatting.None));

            SWFMB.Show(NJJS.SerializeObject(DuoAPI.LearnedSkills(), Newtonsoft.Json.Formatting.None));

            //SWFMB.Show(NJJS.SerializeObject(DuoAPI.VocabularyAsync(), Newtonsoft.Json.Formatting.Indented));

            //SWFMB.Show(NJJS.SerializeObject(DuoAPI.LexemeDataAsync("55", "en"), Newtonsoft.Json.Formatting.Indented));
        }
    }
}