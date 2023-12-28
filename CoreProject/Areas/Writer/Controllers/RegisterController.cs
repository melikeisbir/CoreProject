using CoreProject.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid) //model geçerliyse
            {
              
            }
            return View();
        }
    }
}
