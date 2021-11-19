using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Socrates
{

    public class MessageConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(routeDirection == RouteDirection.IncomingRequest)
            {
                string message = values["message"] as string;
                return (message != null && message.Length >= 2);
            }
            return true;
        }
    }

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Hello", 
                url: "foo/{message}", 
                defaults: new { controller= "Home", action= "Hello", message="Hi" },
                constraints: new {message=new MessageConstraint()}
                );
        }
    }
}
