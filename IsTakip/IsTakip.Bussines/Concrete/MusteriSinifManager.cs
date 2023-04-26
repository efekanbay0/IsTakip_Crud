using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MusteriSinifClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MusteriSinifManager : IMusteriSinifService
    {
        IMusteriSinifDal _musteriSinif;

        public MusteriSinifManager(IMusteriSinifDal musteriSinif)
        {
            _musteriSinif = musteriSinif;
        }

        public void Delete(MusteriSinif item)
        {
            _musteriSinif.Delete(item);
        }

        public List<MusteriSinif> GetAll()
        {
            return _musteriSinif.GetAll();
        }

		public MusteriSinif GetById(int id)
		{
			return _musteriSinif.GetById(id);
		}

		public void Insert(MusteriSinif item)
        {
            _musteriSinif.Insert(item);
        }

        public List<MusteriSinif> List(Expression<Func<MusteriSinif, bool>> Filter)
        {
            return _musteriSinif.List(Filter);
        }

        public void Update(MusteriSinif item)
        {
            _musteriSinif.Update(item);
        }
    }
}
