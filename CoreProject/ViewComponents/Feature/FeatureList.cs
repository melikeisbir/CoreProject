using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.ViewComponents.Feature
{
    public class FeatureList: ViewComponent  //Shared'da oluşturduğumuz componentsde klasör
                                             //oluştururken viewcomponentsde oluşturduğumuz adla aynı olamı
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
