using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ZKM.UI.DAL;
using ZKM.UI.Models;

namespace ZKM.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {                        
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
                        
            Database.SetInitializer<ZkmDbContext>(new ZkmDbInitializer());
        }
    }
}
