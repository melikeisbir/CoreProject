using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
