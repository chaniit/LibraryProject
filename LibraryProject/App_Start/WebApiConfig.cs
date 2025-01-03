﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace LibraryProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var cors = new System.Web.Http.Cors.EnableCorsAttribute("http://localhost:3000", "*", "*");
            config.EnableCors(cors);
        }
    }
}
