using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Abstract
{
    public interface IUserService : IBussinessService<User>
    {
        User Login(string userName,string Password);
    }
}
