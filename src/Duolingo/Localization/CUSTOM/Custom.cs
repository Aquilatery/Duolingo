#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.CUSTOM
{
    #region Custom

    /// <summary>
    /// 
    /// </summary>
    internal class Custom
    {
        #region Messages

        /// <summary>
        /// 
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages { get; set; } = new();
        //default dil belirle. custom dil seçilmiş ve mesaj set edilmemişse default dilin mesajları gösterilsin.
        //veya custom dil seçilemesin fakat custom mesaj set edilmişse oto custom dil seçilmiş olsun.

        #endregion
    }

    #endregion
}