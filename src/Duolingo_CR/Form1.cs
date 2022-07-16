using Duolingo.Enum.Language;
using Duolingo.Struct;
using Duolingo;
using System.Net.Http;
using System.Windows.Forms;
using Duolingo.Enum.Localization;

namespace Duolingo_CR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Localization Localization = new()
            {
                Language = Languages.TR,
                //Messages = new()
                //{
                //    { Code.Empty, "x" },

                //    { Code.Empty_Email_Username, "xx!" },
                //    { Code.Empty_Password, "xxx!" },
                //    { Code.Space_Username, "xxxx!" },
                //    { Code.Space_Email, "xxxxx!" },
                //}
            };

            Account Account = new()
            {
                Email = "alyaxvega@gmail.com",
                Username = "AlyaVega",
                Password = ""
            };

            Duolingo.Duolingo duolingo = new(Localization, Account);
        }
    }
}