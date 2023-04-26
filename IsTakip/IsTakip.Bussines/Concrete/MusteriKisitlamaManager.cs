using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MusteriKisitlamaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MusteriKisitlamaManager : IMusteriKisitlamaService
    {
        IMusteriKisitlamaDal _musteriKisitlama;

        public MusteriKisitlamaManager(IMusteriKisitlamaDal musteriKisitlama)
        {
            _musteriKisitlama = musteriKisitlama;
        }

        public void Delete(MusteriKisitlama item)
        {
            _musteriKisitlama.Delete(item);
        }

        public List<MusteriKisitlama> GetAll()
        {
            return _musteriKisitlama.GetAll();
        }

		public MusteriKisitlama GetById(int id)
		{
			return _musteriKisitlama.GetById(id);
		}

		public void Insert(MusteriKisitlama item)
        {
            _musteriKisitlama.Insert(item);
        }

        public List<MusteriKisitlama> List(Expression<Func<MusteriKisitlama, bool>> Filter)
        {
            return _musteriKisitlama.List(Filter);
        }

        public void Update(MusteriKisitlama item)
        {
            _musteriKisitlama.Update(item);
        }
    }
}
