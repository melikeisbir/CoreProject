using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
