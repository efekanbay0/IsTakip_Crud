using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.AlinanIslerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class AlinanIslerManager : IAlinanIslerService
    {
        IAlinanIslerDal _AlinanIsler;

        public AlinanIslerManager(IAlinanIslerDal alinanIsler)
        {
            _AlinanIsler = alinanIsler;
        }

        public void Delete(AlinanIsler item)
        {
            _AlinanIsler.Delete(item);
        }

        public List<AlinanIsler> GetAll()
        {
            return _AlinanIsler.GetAll();
        }

		public AlinanIsler GetById(int id)
		{
			return _AlinanIsler.GetById(id);
		}

		public void Insert(AlinanIsler item)
        {
            _AlinanIsler.Insert(item);
        }

        public List<AlinanIsler> List(Expression<Func<AlinanIsler, bool>> Filter)
        {
            return _AlinanIsler.List(Filter);
        }

        public void Update(AlinanIsler item)
        {
            _AlinanIsler.Update(item);
        }
    }
}
