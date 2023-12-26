using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager todolistManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = todolistManager.TGetList();
            return View(values);
        }
    }
}
