using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p) //alıcısı olduğumuz mesajlar
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        public async Task<IActionResult> SenderMessage(string p) //göndericisi olduğumuz mesajlar
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(p);
            return View(messageList);
        }
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
    }
}
