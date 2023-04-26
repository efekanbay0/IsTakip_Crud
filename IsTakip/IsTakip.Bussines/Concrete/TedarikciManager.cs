using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.TedarikciClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class TedarikciManager : ITedarikciService
    {
        ITedarikciDal _tedarikci;

        public TedarikciManager(ITedarikciDal tedarikci)
        {
            _tedarikci = tedarikci;
        }

        public void Delete(Tedarikci item)
        {
            _tedarikci.Delete(item); 
        }

        public List<Tedarikci> GetAll()
        {
           return _tedarikci.GetAll();
        }

		public Tedarikci GetById(int id)
		{
			return _tedarikci.GetById(id);
		}

		public void Insert(Tedarikci item)
        {
            _tedarikci.Insert(item);
        }

        public List<Tedarikci> List(Expression<Func<Tedarikci, bool>> Filter)
        {
           return _tedarikci.List(Filter);
        }

        public void Update(Tedarikci item)
        {
            _tedarikci.Update(item);
        }
    }
}
