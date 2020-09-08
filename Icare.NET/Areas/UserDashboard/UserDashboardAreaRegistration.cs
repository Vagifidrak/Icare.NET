using System.Web.Mvc;

namespace Icare.NET.Areas.UserDashboard
{
    public class UserDashboardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserDashboard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserDashboard_default",
                "UserDashboard/{controller}/{action}/{id}",
                new { action = "UserHome,Index", id = UrlParameter.Optional }
            );
        }
    }
}