#region Imports

using SRISLK = System.Runtime.InteropServices.LayoutKind;
using SRISSLA = System.Runtime.InteropServices.StructLayoutAttribute;
using DELL = Duolingo.Enum.Language.Languages;
using SCG = System.Collections.Generic;
using DELC = Duolingo.Enum.Localization.Code;

#endregion

namespace Duolingo.Struct
{
    #region Localization

    /// <summary>
    /// 
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