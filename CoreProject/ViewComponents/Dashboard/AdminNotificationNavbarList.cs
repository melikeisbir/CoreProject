using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class AdminNotificationNavbarList :  ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
