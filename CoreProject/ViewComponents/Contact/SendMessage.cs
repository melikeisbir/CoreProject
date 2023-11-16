using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesajı  kaydedildiği andaki tarih veritabanına kaydedilsin
        //    p.Status = true;  //okuduktan sonra false olacak
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
