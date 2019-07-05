using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DataAccess.Abstract
{
    public interface IToDoItemDal : IEntityRepository<ToDoItem>
    {
        List<ToDoItem> GetById(int Id);
        void DeleteAll(int Filter);
    }
}
