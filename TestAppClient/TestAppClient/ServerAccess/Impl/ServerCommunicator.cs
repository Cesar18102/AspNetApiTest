using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using TestAppClient.ServerAccess.Decl;

namespace TestAppClient.ServerAccess.Impl
{
    public class ServerCommunicator : IServerCommunicator
    {
        public const string SERVER_URL = "http://localhost/api";

        public const string APP_JSON = "application/json";
        public const string APP_URLENCODED = "application/x-www-form-urlencoded";

        private string serverUrl = "";
        public string ServerURL { get { return serverUrl; } set { serverUrl = LastSlash.Replace(value, ""); } }

        private Regex FirstSlash = new Regex("^/");
        private Regex LastSlash = new Regex("/$");

        public ServerCommunicator(string serverUrl = SERVER_URL) => ServerURL = serverUrl;

        public async Task<IServerResponse> SendQuery(IQuery query)
        {
            IDictionary<string, string> Headers = new Dictionary<string, string>();

            try
            {
                string queryUrl = ServerURL + "/" + LastSlash.Replace(FirstSlash.Replace(query.ServerMethod, ""), "");

                (string data, IDictionary<string, string> headers) response = (null, null);

                if (query.Method == QueryMethod.GET)
                    response = await QueryGET(queryUrl, query.ParametersString, query.NeededHeaders);
                else if (query.Method == QueryMethod.POST)
                    response = await QueryPOST(queryUrl, query.QueryBody, query.NeededHeaders);

                return new ServerResponse(response.data, response.headers);
            }
            catch (WebException wex)
            {
                try
                {
                    string error = "";
                    using (StreamReader str = new StreamReader(wex.Response.GetResponseStream()))
                        error = str.ReadToEnd();
                    return new ServerResponse(error, Headers);
                }
                catch (Exception ex)
                {
                    return new ServerResponse(new ResponseException("No Internet connection").ToString(), Headers);
                }
            }
            catch (Exception ex)
            {
                return new ServerResponse(ex.Message, Headers);
            }
        }

        private async Task<(string data, Dictionary<string, string> headers)> QueryGET(string url, string parameterString, IList<string> neededHeadersNames)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url + (parameterString == "" ? "" : "?" + parameterString));
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = APP_URLENCODED;

            return await GetResponse(request, neededHeadersNames);
        }

        private async Task<(string data, Dictionary<string, string> headers)> QueryPOST(string url, string queryBody, IList<string> neededHeadersNames)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = APP_JSON;

            byte[] queryBodyData = Encoding.UTF8.GetBytes(queryBody);
            request.ContentLength = queryBodyData.Length;

            using (Stream strw = await request.GetRequestStreamAsync())
                strw.Write(queryBodyData, 0, queryBodyData.Length);

            return await GetResponse(request, neededHeadersNames);
        }

        protected async Task<(string, Dictionary<string, string>)> GetResponse(HttpWebRequest request, IList<string> neededHeadersNames)
        {
            using (HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse)
            using (StreamReader str = new StreamReader(response.GetResponseStream()))
            {
                Dictionary<string, string> Headers = new Dictionary<string, string>();
                foreach (string neededHeaderName in neededHeadersNames)
                    if (response.Headers.AllKeys.ToList().Contains(neededHeaderName))
                        Headers.Add(neededHeaderName, response.Headers[neededHeaderName]);

                return (str.ReadToEnd(), Headers);
            }
        }
    }
}
