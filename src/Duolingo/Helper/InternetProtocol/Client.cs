#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DHST = Duolingo.Helper.Security.Type;
using SNSPM = System.Net.ServicePointManager;
using DVV = Duolingo.Value.Variable;

#endif

using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;

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

            DVR.HttpClient.DefaultRequestHeaders.Add("User-Agent", DVC.UserAgent);
            //DVR.HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(DVC.UserAgent);

            DVR.HttpClient.BaseAddress = DVR.BaseUri;
        }

        #endregion
    }

    #endregion
}