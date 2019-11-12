using Newtonsoft.Json;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class LogOutQueryFactory : QueryFactory
    {
        private const string LOG_OUT_SERVER_METHOD_NAME = "auth/logout";

        public IQuery LogOut(Session session) =>
            new QueryPost(LOG_OUT_SERVER_METHOD_NAME, JsonConvert.SerializeObject(session));
    }
}
