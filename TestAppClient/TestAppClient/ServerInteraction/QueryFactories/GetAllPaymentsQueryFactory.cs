using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class GetAllPaymentsQueryFactory : QueryFactory
    {
        private const string GET_ALL_PAYMENTS_SERVER_METHOD_NAME = "payment/getall";

        public IQuery GetAllPayments() => new QueryGet(GET_ALL_PAYMENTS_SERVER_METHOD_NAME);
    }
}
