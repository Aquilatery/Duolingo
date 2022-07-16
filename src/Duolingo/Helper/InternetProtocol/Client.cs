#region Imports

using DHST = Duolingo.Helper.Security.Type;
using DVC = Duolingo.Value.Constant;
using DVR = Duolingo.Value.Readonly;
using DVV = Duolingo.Value.Variable;
using SNHHC = System.Net.Http.HttpClient;
using SNSPM = System.Net.ServicePointManager;

#endregion

namespace Duolingo.Helper.InternetProtocol
{
    #region ClientInternetProtocolHelper

    internal class Client
    {
        public static readonly SNHHC HTTPClient = new();

        public Client()
        {
            SNSPM.SecurityProtocol |= DHST.GetType(DVV.ProtocolType);

            HTTPClient.DefaultRequestHeaders.Add("User-Agent", DVC.UserAgent);
            //HTTPClient.DefaultRequestHeaders.UserAgent.ParseAdd(DVC.UserAgent);

            HTTPClient.BaseAddress = DVR.BaseUri;
        }
    }

    #endregion
}