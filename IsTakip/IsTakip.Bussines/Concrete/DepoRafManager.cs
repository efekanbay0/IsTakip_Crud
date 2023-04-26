using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.DepoRafClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class DepoRafManager : IDepoRafService
    {
        IDepoRafDal _depoRaf;

        public DepoRafManager(IDepoRafDal depoRaf)
        {
            _depoRaf = depoRaf;
        }

        public void Delete(DepoRaf item)
        {
            _depoRaf.Delete(item);
        }

        public List<DepoRaf> GetAll()
        {
            return _depoRaf.GetAll();
        }

		public DepoRaf GetById(int id)
		{
			return _depoRaf.GetById(id);
		}

		public void Insert(DepoRaf item)
        {
            _depoRaf.Insert(item);
        }

        public List<DepoRaf> List(Expression<Func<DepoRaf, bool>> Filter)
        {
            return _depoRaf.List(Filter);
        }

        public void Update(DepoRaf item)
        {
            _depoRaf.Update(item);   
        }
    }
}
