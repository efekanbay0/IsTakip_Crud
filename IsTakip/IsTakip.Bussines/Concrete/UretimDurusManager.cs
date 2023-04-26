using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.UretimDurusClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class UretimDurusManager : IUretimDurusService
    {
        IUretimDurusDal _uretimDurus;

        public UretimDurusManager(IUretimDurusDal uretimDurus)
        {
            _uretimDurus = uretimDurus;
        }

        public void Delete(UretimDurus item)
        {
            _uretimDurus.Delete(item);
        }

        public List<UretimDurus> GetAll()
        {
            return _uretimDurus.GetAll();
        }

		public UretimDurus GetById(int id)
		{
			return _uretimDurus.GetById(id);
		}

		public void Insert(UretimDurus item)
        {
            _uretimDurus.Insert(item);
        }

        public List<UretimDurus> List(Expression<Func<UretimDurus, bool>> Filter)
        {
            return _uretimDurus.List(Filter);
        }

        public void Update(UretimDurus item)
        {
           _uretimDurus.Update(item);
        }
    }
}
