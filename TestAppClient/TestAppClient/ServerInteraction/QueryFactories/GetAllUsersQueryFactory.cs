using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class GetAllUsersQueryFactory : QueryFactory
    {
        public const string GET_ALL_USERS_SERVER_METHOD_NAME = "user/getall";

        public IQuery GetAllUsers() => new QueryGet(GET_ALL_USERS_SERVER_METHOD_NAME);
    }
}
