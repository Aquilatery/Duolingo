#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.CM
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

        #endregion
    }

    #endregion
}