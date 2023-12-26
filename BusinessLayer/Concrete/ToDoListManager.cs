using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _todolistDal;

        public ToDoListManager(IToDoListDal todolistDal)
        {
            _todolistDal = todolistDal;
        }

        public void TAdd(ToDoList t)
        {
            _todolistDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todolistDal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _todolistDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todolistDal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todolistDal.Update(t);
        }
    }
}
