using System;
using System.Windows.Forms;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Forms;
using TestAppClient.Controllers;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;
using TestAppClient.ServerInteraction.QueryFactories;
using TestAppClient.ServerInteraction.ResponseParsers;

namespace TestAppClient
{
    public static class Program
    {
        public static IContainer DI { get; private set; }

        private static void InitServices()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<Session>().SingleInstance().AsSelf();

            builder.RegisterType<ServerCommunicator>().SingleInstance().As<IServerCommunicator>();
            builder.RegisterType<JsonResponseParser>().SingleInstance().As<IResponseParser>();

            builder.RegisterType<AuthController>().SingleInstance().AsSelf();
            builder.RegisterType<SignUpQueryFactory>().SingleInstance().AsSelf();
            builder.RegisterType<LogInQueryFactory>().SingleInstance().AsSelf();

            builder.RegisterType<PaymentController>().SingleInstance().AsSelf();
            builder.RegisterType<GetAllPaymentsQueryFactory>().SingleInstance().AsSelf();
            builder.RegisterType<GetPaymentsByCreatorQueryFactory>().SingleInstance().AsSelf();
            builder.RegisterType<AddPaymentQueryFactory>().SingleInstance().AsSelf();

            builder.RegisterType<UserController>().SingleInstance().AsSelf();
            builder.RegisterType<GetAllUsersQueryFactory>().SingleInstance().AsSelf();
            builder.RegisterType<GetUserByIdQueryFactory>().SingleInstance().AsSelf();
            builder.RegisterType<GetUserByLoginQueryFactory>().SingleInstance().AsSelf();

            DI = builder.Build();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
