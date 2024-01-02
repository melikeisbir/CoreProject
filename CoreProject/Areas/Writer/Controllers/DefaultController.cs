using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")] //çalışacağımız areanın adının belirtmeliyiz
    [Authorize]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
