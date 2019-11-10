using Newtonsoft.Json;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class LogInQueryFactory : QueryFactory
    {
        private const string LOG_IN_SERVER_METHOD_NAME = "auth/login";

        public IQuery LogIn(LogInForm logInForm) =>
            new QueryPost(LOG_IN_SERVER_METHOD_NAME, JsonConvert.SerializeObject(logInForm));
    }
}
