#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLCMC = Duolingo.Localization.CM.Custom;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLRUR = Duolingo.Localization.RU.Russian;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DVC = Duolingo.Value.Constant;
using DVV = Duolingo.Value.Variable;
using DVR = Duolingo.Value.Readonly;

#endregion

namespace Duolingo.Helper.Localization
{
    #region Message

    /// <summary>
    /// 
    /// </summary>
    internal class Message
    {
        #region Get

        /// <summary>
        /// 
        /// </summary>
        public static string Get(DELC Code)
        {
            return Get(DVV.SelectLanguage, Code);
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Get(DELL Lang, DELC Code)
        {
            return Lang switch
            {
                DELL.TR => DLTRT.Messages.ContainsKey(Code) ? DLTRT.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
                DELL.EN => DLENE.Messages.ContainsKey(Code) ? DLENE.Messages[Code] : $"[{Code}] {(DVR.NotSetCode.ContainsKey(Lang) ? DVR.NotSetCode[Lang] : DVC.NotSetCode)}",
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