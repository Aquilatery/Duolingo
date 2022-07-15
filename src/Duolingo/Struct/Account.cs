#region Imports

using SRISLK = System.Runtime.InteropServices.LayoutKind;
using SRISSLA = System.Runtime.InteropServices.StructLayoutAttribute;

#endregion

namespace Duolingo.Struct
{
    #region Account

    /// <summary>
    /// 
    /// </summary>
    [SRISSLA(SRISLK.Sequential)]
    public struct Account
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Email;

        /// <summary>
        /// 
        /// </summary>
        public string? Username;

        /// <summary>
        /// 
        /// </summary>
        public string Password;
    }

    #endregion
}