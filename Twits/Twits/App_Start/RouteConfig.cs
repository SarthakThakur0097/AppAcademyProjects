﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Twits
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Twits",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Twit", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}