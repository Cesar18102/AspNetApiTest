using System.Collections.Generic;

using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class GetUserByLoginQueryFactory : QueryFactory
    {
        public const string GET_USER_BY_LOGIN_SERVER_METHOD_NAME = "user/getbylogin";
        public const string USER_LOGIN_PARAM_NAME = "login";

        public IQuery GetUserByLogin(string login) =>
            new QueryGet(GET_USER_BY_LOGIN_SERVER_METHOD_NAME, 
                         parameters: new Dictionary<string, string>() { { USER_LOGIN_PARAM_NAME, login } }
            );
    }
}
