using Kanban.Bussines.Abstract;
using Kanban.DataAccess.Abstract;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Concrete
{
    public class ToDoItemManager : IToDoItemService
    {
        private IToDoItemDal _toDoItemDal;

        public ToDoItemManager(IToDoItemDal toDoItemDal)
        {
            _toDoItemDal = toDoItemDal;
        }

        public void Add(ToDoItem Entity)
        {
            _toDoItemDal.Add(Entity);
        }

        public void Delete(ToDoItem Entity)
        {
            _toDoItemDal.Delete(Entity);
        }

        public List<ToDoItem> GetAll()
        {
            return _toDoItemDal.GetAll();
        }

        public void Update(ToDoItem Entity)
        {
            _toDoItemDal.Update(Entity);
        }
        public List<ToDoItem> GetById(int Id)
        {
            return _toDoItemDal.GetById(Id);
        }

        public void DeleteAll(int Filter)
        {
            _toDoItemDal.DeleteAll(Filter);
        }
    }
}
