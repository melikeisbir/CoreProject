using CoreProject.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager; //sisteme otantike olan kullanıcnın bilgisi için

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //sisteme otantike olan kullanıcnın bilgisi için
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)  //picture nulldan farklıysa
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension; //yeni isim oluşturulma + uzantıdan gelen değer
                var savelocation = resource + "/wwwwroot/userimage/" + imagename; //resmin kaydedileceği lokasyon + kaynaktan gelen değer
                var stream = new FileStream(savelocation, FileMode.Create); //akış + kaydetme
                await p.Picture.CopyToAsync(stream); //streamden gelen akış değerini kopyala
                user.ImageUrl = imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            var result = await _userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
