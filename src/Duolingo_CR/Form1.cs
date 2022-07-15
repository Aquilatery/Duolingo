using Duolingo.Enum.Language;
using System.Windows.Forms;
using System.Net.Http;
using Duolingo.Struct;

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
                Messages = null
            };

            Account account = new()
            {
                Email = "",
                Username = "",
                Password = ""
            };

            Duolingo.Duolingo duolingo = new(localization, account);
        }
    }
}