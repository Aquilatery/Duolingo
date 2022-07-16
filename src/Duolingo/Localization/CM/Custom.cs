#region Imports

using DELC = Duolingo.Enum.Localization.Code;
using SCG = System.Collections.Generic;

#endregion

namespace Duolingo.Localization.CM
{
    #region Custom

    /// <summary>
    /// Localization custom message class.
    /// </summary>
    internal class Custom
    {
        #region Messages

        /// <summary>
        /// The variable with the translations.
        /// </summary>
        public static SCG.Dictionary<DELC, string> Messages { get; set; } = new();

        #endregion
    }

    #endregion
}