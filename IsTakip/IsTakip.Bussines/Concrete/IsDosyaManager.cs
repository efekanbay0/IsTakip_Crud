using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.IsDosyaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class IsDosyaManager : IIsDosyaService
    {
        IIsDosyaDal _isDosya;

        public IsDosyaManager(IIsDosyaDal isDosya)
        {
            _isDosya = isDosya;
        }

        public void Delete(IsDosya item)
        {
            _isDosya.Delete(item);
        }

        public List<IsDosya> GetAll()
        {
            return _isDosya.GetAll();
        }

		public IsDosya GetById(int id)
		{
			return _isDosya.GetById(id);
		}

		public void Insert(IsDosya item)
        {
            _isDosya.Insert(item);
        }

        public List<IsDosya> List(Expression<Func<IsDosya, bool>> Filter)
        {
           return _isDosya.List(Filter);
        }

        public void Update(IsDosya item)
        {
            _isDosya.Update(item);
        }
    }
}
