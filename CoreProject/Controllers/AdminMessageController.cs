using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.Controllers
{
    public class AdminMessageController : Controller //writer bölümündeki mesajların admin tarafında da gözükmesi için
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList() //gelen kutusu - alıcısı olduğumuz mesajlar
        {
            string p;
            p = "admin@gmail.com"; //admine mesaj atılacak
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList() //giden kutusu - göndericisi olduğumuz mesajlar
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
