using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCProjectDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           /* routes.MapRoute(
                name: "UserById",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "GetUserById" }
                );

            routes.MapRoute(
                name: "UpdateUser",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Edit" }
                );

            routes.MapRoute(
                name: "DeleteUser",
                 url: "{controller}/{action}/{id}",
               defaults: new { controller = "User", action = "DeleteUser" }
               );

            routes.MapRoute(
                name: "CakesById",
                url: "{controller}/{action}/{cakeid}",
                defaults: new { controller = "FlavourType", action = "GetCakesById" }
                );
            routes.MapRoute(
                name: "UpdateCake",
                url: "{controller}/{action}/{cakeid}",
                defaults: new { controller = "FlavourType", action = "Edit" }
                );

            routes.MapRoute(
                name: "DeleteCakeById",
                url: "{controller}/{action}/{cakeid}",
                defaults: new { controller = "FlavourType", action = "DeleteUserById" }
                );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


           /* routes.MapRoute(
                name: "AddToCart",
                url: "{controller}/{action}/{FlavourTypeId}/{OrderedQuantity}/{TotalPrice}"
                
            );*/
        }
    }
}
