using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.KullaniciClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullanici;

        public KullaniciManager(IKullaniciDal kullanici)
        {
            _kullanici = kullanici;
        }

        public void Delete(Kullanici item)
        {
            _kullanici.Delete(item);
        }

        public List<Kullanici> GetAll()
        {
           return _kullanici.GetAll();
        }

		public Kullanici GetById(int id)
		{
			return _kullanici.GetById(id);
		}

		public void Insert(Kullanici item)
        {
            _kullanici.Insert(item);
        }

        public List<Kullanici> List(Expression<Func<Kullanici, bool>> Filter)
        {
            return _kullanici.List(Filter);
        }

        public void Update(Kullanici item)
        {
           _kullanici.Update(item);
        }
    }
}
