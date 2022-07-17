#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLCMC = Duolingo.Localization.CM.Custom;
using DLDEG = Duolingo.Localization.DE.German;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLRUR = Duolingo.Localization.RU.Russian;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;

#endregion

namespace Duolingo.Helper.Localization
{
    #region Message

    /// <summary>
    /// Helper localization message class.
    /// </summary>
    internal class Message
    {
        #region Get

        /// <summary>
        /// Function from which language-specific messages are called.
        /// </summary>
        public static string Get(DELC Code)
        {
            return Get(DVV.SelectLanguage, Code);
        }

        /// <summary>
        /// Function from which the message specific to the selected language is called.
        /// </summary>
        public static string Get(DELL Lang, DELC Code)
        {
            return Lang switch
            {
                DELL.TR => DLTRT.Messages.ContainsKey(Code) ? DLTRT.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.EN => DLENE.Messages.ContainsKey(Code) ? DLENE.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.DE => DLDEG.Messages.ContainsKey(Code) ? DLDEG.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.ES => DLESS.Messages.ContainsKey(Code) ? DLESS.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.RU => DLRUR.Messages.ContainsKey(Code) ? DLRUR.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.CM => DLCMC.Messages.ContainsKey(Code) ? DLCMC.Messages[Code] : $"[{Lang}]-[{Code}] {DVC.NotSetCode}",
                _ => $"[{Lang}]-[{Code}] {DVC.NotSetMessage}",
            };
        }

        #endregion
    }

    #endregion
}