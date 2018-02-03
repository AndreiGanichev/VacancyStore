using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Configuration;
using System.Web;
using VacancyStore.DataAccess.Remote;
using VacancyStore.DataAccess.Remote.Helpers;
using VacancyStore.DataAccess.Remote.HHApi;
using VacancyStore.DataAccess.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VacancyStore.Website.App_Start.NinjectConfigurator), "OnStart")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(VacancyStore.Website.App_Start.NinjectConfigurator), "Onstop")]
namespace VacancyStore.Website.App_Start
{
    public static class NinjectConfigurator
    {
        private static Bootstrapper _bootstrapper = new Bootstrapper();

        public static void OnStart()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            _bootstrapper.Initialize(CreateKernel);
        }

        public static void OnStop()
        {
            _bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(c => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IVacancyRepository>().To<RemoteRepository>();
            kernel.Bind<IApiClient>().To<HHApiClient>();
            kernel.Bind<RestApiClient>().ToConstructor(
               c => new RestApiClient(ConfigurationManager.AppSettings["ApiBaseUrl"]));
        }
    }
}