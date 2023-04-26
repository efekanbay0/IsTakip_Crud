using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class DepoEnvanterManager : IDepoEnvanterService
    {
        IDepoEnvanterDal _depoEnvanter;

        public DepoEnvanterManager(IDepoEnvanterDal depoEnvanter)
        {
            _depoEnvanter = depoEnvanter;
        }

        public void Delete(DepoEnvanter item)
        {
            _depoEnvanter.Delete(item);
        }

        public List<DepoEnvanter> GetAll()
        {
           return _depoEnvanter.GetAll();
        }

		public DepoEnvanter GetById(int id)
		{
			return _depoEnvanter.GetById(id);
		}

		public void Insert(DepoEnvanter item)
        {
           _depoEnvanter.Insert(item);
        }

        public List<DepoEnvanter> List(Expression<Func<DepoEnvanter, bool>> Filter)
        {
            return _depoEnvanter.List(Filter);
        }

        public void Update(DepoEnvanter item)
        {
            _depoEnvanter.Update(item);
        }
    }
}
