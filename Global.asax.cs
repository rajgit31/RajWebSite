using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RajSoftware
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    /// <summary>
    /// MvcApplication
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Registers the routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add("ImageRoutes", new Route("{controller}/Images/{filename}", new CustomRouteHandler()));
            
            routes.MapRoute(
               "Default",                                              // Route name
               "{controller}/{action}/{id}",                           // URL with parameters
               new { controller = "Home", action = "Display", id = "" }  // Parameter defaults
            );

            
        }

        /// <summary>
        /// Application_s the start.
        /// </summary>
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
            //RegisterViewEngines(ViewEngines.Engines); 
        }

        //public static void RegisterViewEngines(ViewEngineCollection viewEngines) 
        //{ 
        //    viewEngines.Clear();
        //    viewEngines.Add(new MobileCapableWebFormViewEngine()); 
        //} 
    }
}
