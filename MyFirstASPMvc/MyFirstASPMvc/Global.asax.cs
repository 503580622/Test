using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyFirstASPMvc.Models;
using System.Threading;
using System.Globalization;

namespace MyFirstASPMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			Database.SetInitializer<MusicStoreDB>(new MusicStoreDbInitializer());

			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US"); 

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}
