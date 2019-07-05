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
    public class DependencyManager : IDependencyService
    {
        private IDependenciesDal _dependenciesDal;

        public DependencyManager(IDependenciesDal dependenciesDal)
        {
            _dependenciesDal = dependenciesDal;
        }

        public void Add(Dependency Entity)
        {
            _dependenciesDal.Add(Entity);
        }

        public void Delete(Dependency Entity)
        {
            _dependenciesDal.Delete(Entity);
        }

        public List<Dependency> GetAll()
        {
            return _dependenciesDal.GetAll();
        }

        public void Update(Dependency Entity)
        {
            _dependenciesDal.Update(Entity);
        }
    }
}
