using Kanban.Bussines.Abstract;
using Kanban.DataAccess.Abstract;
using Kanban.DataAccess.Concreate.EntityFramework;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void Add(ToDoList Entity)
        {
            _toDoListDal.Add(Entity);
        }

        public void Delete(ToDoList Entity)
        {
            _toDoListDal.Delete(Entity);
        }

        public List<ToDoList> GetAll()
        {
            return _toDoListDal.GetAll();
        }

        public void Update(ToDoList Entity)
        {
            _toDoListDal.Update(Entity);
        }
        public List<ToDoList> GetListById(int filter)
        {
            return _toDoListDal.GetListById(filter);
        }
       
    }
}
