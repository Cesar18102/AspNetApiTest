using System.Web;
using System.Web.Http;

using Autofac;
using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Util;

namespace AspNetBlankAppTest
{
    public class WebApiApplication : HttpApplication
    {
        public static IContainer DI { get; private set; }

        private void InitServices()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<MySqlRepoFactory>().SingleInstance().As<IRepoFactory>();
            builder.RegisterType<SessionTable>().SingleInstance().AsSelf();

            DI = builder.Build();
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            InitServices();
        }
    }
}
