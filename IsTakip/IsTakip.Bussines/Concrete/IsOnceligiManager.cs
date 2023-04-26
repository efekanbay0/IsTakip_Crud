using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.IsOnceligiClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class IsOnceligiManager : IIsOnceligiService
    {
        IIsOnceligiDAl _isOnceligi;

        public IsOnceligiManager(IIsOnceligiDAl isOnceligi)
        {
            _isOnceligi = isOnceligi;
        }

        public void Delete(IsOnceligi item)
        {
            _isOnceligi.Delete(item);
        }

        public List<IsOnceligi> GetAll()
        {
            return _isOnceligi.GetAll();    
        }

		public IsOnceligi GetById(int id)
		{
			return _isOnceligi.GetById(id);
		}

		public void Insert(IsOnceligi item)
        {
            _isOnceligi.Insert(item);
        }

        public List<IsOnceligi> List(Expression<Func<IsOnceligi, bool>> Filter)
        {
            return _isOnceligi.List(Filter);
        }

        public void Update(IsOnceligi item)
        {
            _isOnceligi.Update(item);
        }
    }
}
