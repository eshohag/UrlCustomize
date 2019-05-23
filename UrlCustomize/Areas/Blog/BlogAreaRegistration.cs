using System.Web.Mvc;
using System.Web.Routing;

namespace UrlCustomize.Areas.Blog
{
    public class BlogAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Blog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(
                "Blog_Post",
                "Blog/{controller}/{action}/{date}/{serial}/{article}",
                new { action = "Index", date = UrlParameter.Optional, serial = UrlParameter.Optional, article = UrlParameter.Optional },
                new
                {
                    date = @"^[0-9] $",
                    serial = @"^[0-9] $",
                    method = new HttpMethodConstraint("Get")
                });

            context.MapRoute(
                "Blog_default",
                "Blog/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}