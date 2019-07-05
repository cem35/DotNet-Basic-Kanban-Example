using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Abstract
{
    public interface IBussinessService<T>
    {
        List<T> GetAll();
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
