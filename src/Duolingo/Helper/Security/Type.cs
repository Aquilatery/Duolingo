#region Imports

using DESPT = Duolingo.Enum.Security.ProtocolType;
using SNSPT = System.Net.SecurityProtocolType;

#endregion

namespace Duolingo.Helper.Security
{
    #region TypeSecurityHelper

    internal class Type
    {
        public static SNSPT GetType(DESPT Type)
        {
            return Type switch
            {
                DESPT.TLS => SNSPT.Tls,
                DESPT.SSL3 => SNSPT.Ssl3,
                DESPT.TLS11 => SNSPT.Tls11,
                DESPT.TLS12 => SNSPT.Tls12,
                DESPT.TLS13 => SNSPT.Tls13,
                _ => SNSPT.SystemDefault,
            };
        }
    }

    #endregion
}