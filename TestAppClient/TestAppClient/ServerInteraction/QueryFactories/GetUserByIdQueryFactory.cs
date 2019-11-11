using System.Collections.Generic;

using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class GetUserByIdQueryFactory : QueryFactory
    {
        public const string GET_USER_BY_ID_SERVER_METHOD_NAME = "user/getbyid";
        public const string USER_ID_PARAM_NAME = "id";

        public IQuery GetUserById(int id) =>
            new QueryGet(GET_USER_BY_ID_SERVER_METHOD_NAME, 
                         parameters: new Dictionary<string, string>() { { USER_ID_PARAM_NAME, id.ToString() } }
            );
    }
}
