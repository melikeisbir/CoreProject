using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
