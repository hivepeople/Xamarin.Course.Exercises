using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiVersionCheckAssignment.VersionCheck;

namespace WebApiVersionCheckAssignment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Register version checker
            config.MessageHandlers.Add(new VersionCheckHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
