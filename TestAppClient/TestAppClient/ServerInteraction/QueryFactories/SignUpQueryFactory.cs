using System.Threading.Tasks;

using Newtonsoft.Json;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public class SignUpQueryFactory : QueryFactory
    {
        private const string SIGN_UP_SERVER_METHOD_NAME = "auth/signup";

        public IQuery SignUp(SignUpForm signUpForm) =>
            new QueryPost(SIGN_UP_SERVER_METHOD_NAME, JsonConvert.SerializeObject(signUpForm));
    }
}
