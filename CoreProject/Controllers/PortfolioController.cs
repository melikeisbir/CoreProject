using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace CoreProject.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi ";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme ";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
          

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results= validations.Validate(p);
            if(results.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach  (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
