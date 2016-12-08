using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiAttributeRouting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            // This is the magic line that enables attribute routing. Usually it will
            // already be here, so you don't need to add it yourself
            config.MapHttpAttributeRoutes();

            // This is the default convention-based routing setup. We don't need it
            // if we use attribute routing everywhere
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
