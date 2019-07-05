using Kanban.Bussines.Abstract;
using Kanban.DataAccess.Abstract;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Bussines.Concrete
{
    public class UserManager: IUserService
    {
        private IUserDal _userDal;
        public UserManager( IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public User Login(string userName, string Password)
        {
            return _userDal.Login( userName, Password);
        }
    }
}
