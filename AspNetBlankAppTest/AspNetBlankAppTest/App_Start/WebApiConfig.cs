using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNetBlankAppTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "PublicApi",
                routeTemplate: "api/{controller}/{action}"
            );

            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml")
            );
        }
    }
}
