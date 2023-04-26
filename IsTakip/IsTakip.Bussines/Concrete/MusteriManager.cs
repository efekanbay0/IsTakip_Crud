using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteri;

        public MusteriManager(IMusteriDal musteri)
        {
            _musteri = musteri;
        }

        public void Delete(Musteri item)
        {
            _musteri.Delete(item);  
        }

        public List<Musteri> GetAll()
        {
            return _musteri.GetAll();
        }

		public Musteri GetById(int id)
		{
			return _musteri.GetById(id);
		}

		public void Insert(Musteri item)
        {
            _musteri.Insert(item);
        }

        public List<Musteri> List(Expression<Func<Musteri, bool>> Filter)
        {
            return _musteri.List(Filter);
        }

        public void Update(Musteri item)
        {
            _musteri.Update(item);
        }
    }
}
