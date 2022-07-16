#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLCMC = Duolingo.Localization.CUSTOM.Custom;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DVC = Duolingo.Value.Constant;
using DVV = Duolingo.Value.Variable;

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
                DELL.TR => DLTRT.Messages.ContainsKey(Code) ? DLTRT.Messages[Code] : DVC.NotSetCode,
                DELL.EN => DLENE.Messages.ContainsKey(Code) ? DLENE.Messages[Code] : DVC.NotSetCode,
                DELL.ES => DLESS.Messages.ContainsKey(Code) ? DLESS.Messages[Code] : DVC.NotSetCode,
                DELL.CUSTOM => DLCMC.Messages.ContainsKey(Code) ? DLCMC.Messages[Code] : DVC.NotSetCode,
                _ => DVC.NotSetMessage,
            };
        }

        #endregion
    }

    #endregion
}