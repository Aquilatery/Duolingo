#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

#region Imports

using DESPT = Duolingo.Enum.Security.ProtocolType;
using SNSPT = System.Net.SecurityProtocolType;

#endregion

namespace Duolingo.Helper.Security
{
    #region TypeSecurityHelper

    /// <summary>
    /// Helper security type class.
    /// </summary>
    internal class Type
    {
        /// <summary>
        /// Function by which the security protocol is selected.
        /// </summary>
        /// <param name="Type">ProtocolType</param>
        /// <returns></returns>
        public static SNSPT GetType(DESPT Type)
        {
#if NET48 || NET5_0_OR_GREATER || NETCOREAPP3_1_OR_GREATER

            return Type switch
            {
                DESPT.TLS => SNSPT.Tls,
                DESPT.SSL3 => SNSPT.Ssl3,
                DESPT.TLS11 => SNSPT.Tls11,
                DESPT.TLS12 => SNSPT.Tls12,
                DESPT.TLS13 => SNSPT.Tls13,
                _ => SNSPT.SystemDefault,
            };

#else

            return Type switch
            {
                DESPT.TLS => (SNSPT)192,
                DESPT.SSL3 => (SNSPT)48,
                DESPT.TLS11 => (SNSPT)768,
                DESPT.TLS12 => (SNSPT)3072,
                DESPT.TLS13 => (SNSPT)12288,
                _ => 0,
            };

#endif
        }
    }

    #endregion
}

#endif