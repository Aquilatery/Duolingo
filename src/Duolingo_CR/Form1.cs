using Duolingo.Enum.Language;
using Duolingo.Struct;
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

            Localization localization = new()
            {
                Language = Languages.TR,
                Messages = new()
                {
                    { Code.Empty, "Пустой" },

                    { Code.Empty_Email_Username, "Электронная почта или имя пользователя не могут быть пустыми!" },
                    { Code.Empty_Password, "Пароль не может быть пустым!" },
                    { Code.Space_Username, "Имя пользователя не может содержать пробелы!" },
                    { Code.Space_Email, "Электронная почта не может содержать пробелов!" },
                }
            };

            Account account = new()
            {
                Email = "",
                Username = "AlyaVega",
                Password = ""
            };

            Duolingo.Duolingo duolingo = new(localization, account);
        }
    }
}