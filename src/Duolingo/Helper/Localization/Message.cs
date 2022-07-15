#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using DLTRT = Duolingo.Localization.TR.Turkish;
using DLENE = Duolingo.Localization.EN.English;
using DLESS = Duolingo.Localization.ES.Spanish;
using DLCMC = Duolingo.Localization.CUSTOM.Custom;
using DVC = Duolingo.Value.Constant;

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
        public static string Get(DELL Lang, DELC Code)
        {
            return Lang switch
            {
                DELL.TR => DLTRT.Messages[Code],
                DELL.EN => DLENE.Messages[Code],
                DELL.ES => DLESS.Messages[Code],
                DELL.CUSTOM => DLCMC.Messages[Code],
                _ => DVC.NotSetMessage,
            };
        }

        #endregion
    }

    #endregion
}