#region Imports

#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

using DHST = Duolingo.Helper.Security.Type;
using SNSPM = System.Net.ServicePointManager;
using DVV = Duolingo.Value.Variable;

#endif

using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using SNHHC = System.Net.Http.HttpClient;

#endregion

namespace Duolingo.Helper.InternetProtocol
{
    #region ClientInternetProtocolHelper

    internal class Client
    {
        public static readonly SNHHC HTTPClient = new();

        public Client()
        {
#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

            SNSPM.SecurityProtocol |= DHST.GetType(DVV.ProtocolType);

#endif

            HTTPClient.DefaultRequestHeaders.Add("User-Agent", DVC.UserAgent);
            //HTTPClient.DefaultRequestHeaders.UserAgent.ParseAdd(DVC.UserAgent);

            HTTPClient.BaseAddress = DVR.BaseUri;
        }
    }

    #endregion
}