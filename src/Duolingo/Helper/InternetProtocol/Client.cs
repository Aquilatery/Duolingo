#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DHST = Duolingo.Helper.Security.Type;
using SNSPM = System.Net.ServicePointManager;

#endif

using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;
using STS = System.TimeSpan;

#endregion

namespace Duolingo.Helper.InternetProtocol
{
    #region Client

    /// <summary>
    /// Helper internet protocol client class.
    /// </summary>
    internal class Client
    {
        #region Client

        /// <summary>
        /// The client to which the connections are made.
        /// </summary>
        public Client()
        {
#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

            SNSPM.SecurityProtocol |= DHST.GetType(DVV.ProtocolType);

#endif

            DVR.HttpClient.Timeout = STS.FromSeconds(DVV.Timeout);

            DVR.HttpClient.BaseAddress = DVR.BaseUri;
        }

        #endregion
    }

    #endregion
}