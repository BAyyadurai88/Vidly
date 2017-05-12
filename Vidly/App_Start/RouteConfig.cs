using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();//New way to Custom route mapping with MVC 5

            #region Conventional Custom Route Config
            //New routes should be specified first - sequence matters
            //Order is usally most specific to most generic
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new {Controller="Movies", action="ByReleaseDate"},
            //    new {year =@"\d{4}", month=@"\d{2}"}); // new route map with constrains using verbatum string(@) on the input params\
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
