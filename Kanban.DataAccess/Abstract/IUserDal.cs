using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        User Login(string userName,string password);
    }
}
