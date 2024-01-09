using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
