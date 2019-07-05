using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Entities.Concrete
{
    public class ToDoItemListView
    {
        //[System.ComponentModel.Browsable(false)]
        public int Id{ get; set; }

        //[System.ComponentModel.Browsable(false)]
        public int ToDoListId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public string Status { get; set; }
    }
}
