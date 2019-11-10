using Newtonsoft.Json;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class AddPaymentQueryFactory : QueryFactory
    {
        private const string ADD_PAYMENTS_SERVER_METHOD_NAME = "payment/add";

        public IQuery Add(AddPaymentForm addPaymentForm) =>
            new QueryPost(ADD_PAYMENTS_SERVER_METHOD_NAME, JsonConvert.SerializeObject(addPaymentForm));
    }
}
