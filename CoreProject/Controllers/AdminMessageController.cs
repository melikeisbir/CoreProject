using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AdminMessageController : Controller //writer bölümündeki mesajların admin tarafında da gözükmesi için
    {
        WriterMessageManager WriterMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList() //gelen kutusu - alıcısı olduğumuz mesajlar
        {
            string p;
            p = "admin@gmail.com"; //admine mesaj atılacak
            var values = WriterMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList() //giden kutusu - göndericisi olduğumuz mesajlar
        {
            string p;
            p = "admin@gmail.com";
            var values = WriterMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = WriterMessageManager.TGetByID(id);
            return View(values);
        }
    }
}
