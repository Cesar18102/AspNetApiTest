using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerInteraction.QueryFactories;
using TestAppClient.ServerInteraction.ResponseParsers;

namespace TestAppClient.Controllers
{
    public class PaymentController
    {
        public async Task<IEnumerable<Payment>> GetAll()
        {
            IQuery getAllPaymentsQuery = Program.DI.Resolve<GetAllPaymentsQueryFactory>().GetAllPayments();
            IServerResponse response = await Program.DI.Resolve<IServerCommunicator>().SendQuery(getAllPaymentsQuery);
            return Program.DI.Resolve<IResponseParser>().ParseCollection<Payment>(response);
        }

        public async Task<IEnumerable<Payment>> GetByCreator(int id)
        {
            IQuery getPaymentsByCreatorQuery = Program.DI.Resolve<GetPaymentsByCreatorQueryFactory>().GetByCreator(id);
            IServerResponse response = await Program.DI.Resolve<IServerCommunicator>().SendQuery(getPaymentsByCreatorQuery);
            return Program.DI.Resolve<IResponseParser>().ParseCollection<Payment>(response);
        }

        public async Task<Payment> Add(AddPaymentForm addPaymentForm)
        {
            IQuery addPaymentQuery = Program.DI.Resolve<AddPaymentQueryFactory>().Add(addPaymentForm);
            IServerResponse response = await Program.DI.Resolve<IServerCommunicator>().SendQuery(addPaymentQuery);
            return Program.DI.Resolve<IResponseParser>().Parse<Payment>(response);
        }
    }
}
