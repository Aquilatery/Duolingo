#region Imports

using DESPT = Duolingo.Enum.Security.ProtocolType;
using SRISLK = System.Runtime.InteropServices.LayoutKind;
using SRISSLA = System.Runtime.InteropServices.StructLayoutAttribute;
using STE = System.Text.Encoding;

#endregion

namespace Duolingo.Struct
{
    #region Client

    /// <summary>
    /// 
    /// </summary>
    [SRISSLA(SRISLK.Sequential)]
    public struct Client
    {
        /// <summary>
        /// 
        /// </summary>
        public DESPT ProtocolType;

        /// <summary>
        /// 
        /// </summary>
        public STE EncodingType;
    }

    #endregion
}