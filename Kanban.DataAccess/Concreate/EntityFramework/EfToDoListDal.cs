
using Kanban.DataAccess.Abstract;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DataAccess.Concreate.EntityFramework
{
    public class EfToDoListDal : EfEntityRepositoryBase<ToDoList, KanbanContext>, IToDoListDal
    {
        public List<ToDoList> GetListById(int filter)
        {
            using (KanbanContext context = new KanbanContext())
            {
                return context.ToDoLists.Where(x => x.UserId == filter).ToList();

            }
        }
    }
}
