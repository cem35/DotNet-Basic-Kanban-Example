using Kanban.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Entities.Concrete
{
    public class ToDoItem : IEntityDal
    {
        public int Id { get; set; }
        public int ToDoListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public int DepId { get; set; }

    }
}
