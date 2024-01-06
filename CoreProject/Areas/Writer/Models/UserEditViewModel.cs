using Microsoft.AspNetCore.Http;

namespace CoreProject.Areas.Writer.Models
{
    public class UserEditViewModel //güncellenecek alanlar
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureURL { get; set; }
        public IFormFile Picture { get; set; } //dosya yollu
    }
}
