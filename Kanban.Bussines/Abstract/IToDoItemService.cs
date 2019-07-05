using Kanban.DataAccess.Abstract;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Abstract
{
    public interface IToDoItemService : IBussinessService<ToDoItem>
    {
        List<ToDoItem> GetById(int Id);
        void DeleteAll(int Filter);
    }
}
