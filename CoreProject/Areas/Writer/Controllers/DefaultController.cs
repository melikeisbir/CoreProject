using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")] //çalışacağımız areanın adının belirtmeliyiz
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
