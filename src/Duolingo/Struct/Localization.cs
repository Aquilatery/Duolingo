#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using DELL = Duolingo.Enum.Language.Languages;
using SCG = System.Collections.Generic;
using SRISLK = System.Runtime.InteropServices.LayoutKind;
using SRISSLA = System.Runtime.InteropServices.StructLayoutAttribute;

#endregion

namespace Duolingo.Struct
{
    #region Localization

    /// <summary>
    /// Struct localization.
    /// </summary>
    [SRISSLA(SRISLK.Sequential)]
    public struct Localization
    {
        /// <summary>
        /// 
        /// </summary>
        public DELL Language;

        /// <summary>
        /// 
        /// </summary>
        public SCG.Dictionary<DELC, string>? Messages;
    }

    #endregion
}