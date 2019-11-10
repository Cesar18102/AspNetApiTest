using Autofac;

using System.Threading.Tasks;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerInteraction.QueryFactories;
using TestAppClient.ServerInteraction.ResponseParsers;

namespace TestAppClient.Controllers
{
    public class SignUpController
    {
        public async Task<Session> SignUp(SignUpForm signUpForm)
        {
            IQuery signUpQuery = Program.DI.Resolve<SignUpQueryFactory>().SignUp(signUpForm);
            IServerResponse response = await Program.DI.Resolve<IServerCommunicator>().SendQuery(signUpQuery);
            return Program.DI.Resolve<IResponseParser>().Parse<Session>(response);
        }
    }
}
