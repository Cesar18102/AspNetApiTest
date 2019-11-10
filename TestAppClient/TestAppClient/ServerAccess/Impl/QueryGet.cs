using System.Collections.Generic;

using TestAppClient.ServerAccess.Decl;

namespace TestAppClient.ServerAccess.Impl
{
    public class QueryGet : Query
    {
        public QueryGet(string serverMethod, string queryBody = "", IDictionary<string, string> parameters = null) : 
            base(QueryMethod.GET, serverMethod, queryBody, parameters) { }
    }
}
