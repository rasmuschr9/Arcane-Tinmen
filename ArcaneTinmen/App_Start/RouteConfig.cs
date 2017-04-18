using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ArcaneTinmen
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: null,
            url: "{controller}",
            defaults: new
            {
                controller = "Home",
                action = "Index",
                size =
           (string)null,
                page = 1
            }
            );
            routes.MapRoute(
            name: null,
            url: "{controller}/Page{page}",
            defaults: new
            {
                controller = "Product",
                action = "Index",
                size =
           (string)null
            },
            constraints: new { page = @"\d+" }
            );
            routes.MapRoute(
            name: null,
            url: "Product/{size}",
            defaults: new { controller = "Product", action = "Index", page = 1 }
            );
            routes.MapRoute(
            name: null,
            url: "{controller}/{size}/Page{page}",
            defaults: new { controller = "Product", action = "Index" },

            constraints: new { page = @"\d+" }
            );
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new
            {
                controller = "Product",
                action = "Index",
                id =
           UrlParameter.Optional
            }
            );
        }
    }
}
