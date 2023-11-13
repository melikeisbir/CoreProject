using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
