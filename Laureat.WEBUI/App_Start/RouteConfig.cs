using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Laureat.WEBUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "User", action = "List" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "List", id = UrlParameter.Optional }
            );
            routes.MapRoute(null, "",
                new
                {
                    controller = "User",
                    action = "List",
                    role = (string)null,
                    page = 1
                }
            );
            routes.MapRoute(null, "Page{page}",
                new
                {
                    controller = "User",
                    action = "List",
                    role = (string)null,
                },
                new { page = @"\d+" }
            );

            routes.MapRoute(null, 
                "{Role}",
                 new { controller = "User", action = "List", page = 1 }
            );
            

            routes.MapRoute(null,
                "{role}/Page{page}",
                new { controller = "User", action = "List" },
                new { page = @"\+" }
            );
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
