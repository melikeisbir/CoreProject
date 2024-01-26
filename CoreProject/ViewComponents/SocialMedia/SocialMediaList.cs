using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
