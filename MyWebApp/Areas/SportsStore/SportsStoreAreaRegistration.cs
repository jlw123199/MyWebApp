using System.Web.Mvc;

namespace MyWebApp.Areas.SportsStore
{
    public class SportsStoreAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SportsStore";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
             

            context.MapRoute(
                "SportsStore_default",
                "SportsStore/{controller}/{action}/{id}",
                new { action = "List", id = UrlParameter.Optional }
            ); 
        }
    }
}