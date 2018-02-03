using System.Web.Mvc;
using System.Web.Routing;
using VacancyStore.Website.App_Start;

namespace VacancyStore.Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ObjectMappingConfigurator.Configure();
        }
    }
}
