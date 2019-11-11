using System.Threading.Tasks;

using Autofac;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerInteraction.QueryFactories;
using TestAppClient.ServerInteraction.ResponseParsers;

namespace TestAppClient.Controllers
{
    public class UserController
    {
        public async Task<UserInfo> GetUserById(int id)
        {
            IQuery getUserByIdQuery = Program.DI.Resolve<GetUserByIdQueryFactory>().GetUserById(id);
            IServerResponse response = await Program.DI.Resolve<IServerCommunicator>().SendQuery(getUserByIdQuery);
            return Program.DI.Resolve<IResponseParser>().Parse<UserInfo>(response);
        }
    }
}
