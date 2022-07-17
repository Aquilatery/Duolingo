#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DESPT = Duolingo.Enum.Security.ProtocolType;

#endif

using SRISLK = System.Runtime.InteropServices.LayoutKind;
using SRISSLA = System.Runtime.InteropServices.StructLayoutAttribute;
using STE = System.Text.Encoding;

#endregion

namespace Duolingo.Struct
{
    #region Client

    /// <summary>
    /// Struct client.
    /// </summary>
    [SRISSLA(SRISLK.Sequential)]
    public struct Client
    {
#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

        /// <summary>
        /// 
        /// </summary>
        public DESPT ProtocolType;

#endif

        /// <summary>
        /// 
        /// </summary>
        public int Timeout;

        /// <summary>
        /// 
        /// </summary>
        public string UserAgent;

        /// <summary>
        /// 
        /// </summary>
        public STE EncodingType;
    }

    #endregion
}