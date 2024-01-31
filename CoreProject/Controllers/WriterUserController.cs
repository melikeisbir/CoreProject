using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class WriterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
