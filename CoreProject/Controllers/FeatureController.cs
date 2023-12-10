using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
