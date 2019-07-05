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
    public class EfUserDal : EfEntityRepositoryBase<User, KanbanContext>, IUserDal
    {
        public User Login(string userName, string password)
        {
             using (KanbanContext context = new KanbanContext())
             {
                //var user = context.Users.Where(x => x.Name == userName && x.Password == password).SingleOrDefault();
                // return (user == null) ? false : true;
                return context.Users.Where(x => x.Name == userName && x.Password == password).SingleOrDefault();
             }
        }
    }
}
