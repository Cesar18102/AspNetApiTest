using System.Collections.Generic;

using TestAppClient.ServerAccess.Decl;

namespace TestAppClient.ServerAccess.Impl
{
    public class QueryPost : Query
    {
        public QueryPost(string serverMethod, string queryBody = "", IDictionary<string, string> parameters = null) : 
            base(QueryMethod.POST, serverMethod, queryBody, parameters) { }
    }
}
