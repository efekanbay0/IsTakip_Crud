using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MusteriTemsilciClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MusteriTemsilciManager : IMusteriTemsilciSerivice
    {
        IMusteriTemsilciDal _musteriTemsilci;

        public MusteriTemsilciManager(IMusteriTemsilciDal musteriTemsilci)
        {
            _musteriTemsilci = musteriTemsilci;
        }

        public void Delete(MusteriTemsilci item)
        {
            _musteriTemsilci.Delete(item);
        }

        public List<MusteriTemsilci> GetAll()
        {
            return _musteriTemsilci.GetAll();
        }

		public MusteriTemsilci GetById(int id)
		{
			return _musteriTemsilci.GetById(id);
		}

		public void Insert(MusteriTemsilci item)
        {
            _musteriTemsilci.Insert(item);
        }

        public List<MusteriTemsilci> List(Expression<Func<MusteriTemsilci, bool>> Filter)
        {
           return _musteriTemsilci.List(Filter);
        }

        public void Update(MusteriTemsilci item)
        {
            _musteriTemsilci.Update(item);
        }
    }
}
