using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.KalinlikClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class KalinlikManager : IKalinlikService
    {
        IKalinlikDal _kalinlik;

        public KalinlikManager(IKalinlikDal kalinlik)
        {
            _kalinlik = kalinlik;
        }

        public void Delete(Kalinlik item)
        {
           _kalinlik.Delete(item);
        }

        public List<Kalinlik> GetAll()
        {
            return _kalinlik.GetAll();
        }

		public Kalinlik GetById(int id)
		{
			return _kalinlik.GetById(id);
		}

		public void Insert(Kalinlik item)
        {
            _kalinlik.Insert(item);
        }

        public List<Kalinlik> List(Expression<Func<Kalinlik, bool>> Filter)
        {
            return  _kalinlik.List(Filter);
        }

        public void Update(Kalinlik item)
        {
            _kalinlik.Update(item);
        }
    }
}
