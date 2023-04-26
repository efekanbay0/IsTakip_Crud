using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.DepoClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    internal class DepoManager : IDepoService
    {
        IDepoDal _Depo;

        public DepoManager(IDepoDal depo)
        {
            _Depo = depo;
        }

        public void Delete(Depo item)
        {
            _Depo.Delete(item);
        }

        public List<Depo> GetAll()
        {
            return _Depo.GetAll();  
        }

		public Depo GetById(int id)
		{
			return _Depo.GetById(id);
		}

		public void Insert(Depo item)
        {
            _Depo.Insert(item);
        }

        public List<Depo> List(Expression<Func<Depo, bool>> Filter)
        {
           return _Depo.List(Filter);
        }

        public void Update(Depo item)
        {
            _Depo.Update(item);
        }
    }
}
