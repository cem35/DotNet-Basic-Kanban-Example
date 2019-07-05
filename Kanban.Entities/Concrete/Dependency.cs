using Kanban.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Entities.Concrete
{
    public class Dependency:IEntityDal
    {
        public int Id { get; set; }
        public int ToDoItem1 { get; set; }
        public int ToDoItem2 { get; set; }
        public int Status { get; set; }
    }
}
