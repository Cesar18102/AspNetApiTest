using System.Collections.Generic;

using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class GetPaymentsByCreatorQueryFactory : QueryFactory
    {
        private const string GET_PAYMENTS_BY_CREATOR_SERVER_METHOD_NAME = "payment/getbycreator";
        private const string CREATOR_ID_PARAM_NAME = "id";

        public IQuery GetByCreator(int id) =>
            new QueryGet(GET_PAYMENTS_BY_CREATOR_SERVER_METHOD_NAME, 
                         parameters: new Dictionary<string, string>() { { CREATOR_ID_PARAM_NAME, id.ToString() } }
            );
    }
}
