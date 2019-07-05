using Kanban.DataAccess.Abstract;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DataAccess.Concreate.EntityFramework
{
    public class EfToDoItemDal : EfEntityRepositoryBase<ToDoItem, KanbanContext>, IToDoItemDal
    {
        public List<ToDoItem> GetById(int filter)
        {
            using (KanbanContext context = new KanbanContext())
            {
                 return context.ToDoItems.Where(x => x.ToDoListId == filter).ToList();
                
            }
        }

        public void DeleteAll(int filter)
        {
            using (KanbanContext context = new KanbanContext())
            {
                while ((context.ToDoItems.Where(x => x.ToDoListId == filter)) != null)
                {
                    var item = context.ToDoItems.Where(x => x.ToDoListId == filter).FirstOrDefault();
                    if (item != null)
                    {
                        var deletedEntity = context.Entry(item);
                        deletedEntity.State = EntityState.Deleted;
                        context.SaveChanges();
                    }
                    else break;
                   
                }

            }
        }
    }
}
