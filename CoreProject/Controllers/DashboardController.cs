using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard ";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistikler Sayfası";
            return View();
        }
    }
}
