using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.DurusTipClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class DurusTipManager : IDurusTipService
    {
        IDurusTipDal _durusTip;

        public DurusTipManager(IDurusTipDal durusTip)
        {
            _durusTip = durusTip;
        }

        public void Delete(DurusTip item)
        {
            _durusTip.Delete(item); 
        }

        public List<DurusTip> GetAll()
        {
            return _durusTip.GetAll();
        }

		public DurusTip GetById(int id)
		{
			return _durusTip.GetById(id);
		}

		public void Insert(DurusTip item)
        {
           _durusTip.Insert(item);
        }

        public List<DurusTip> List(Expression<Func<DurusTip, bool>> Filter)
        {
            return _durusTip.List(Filter);
        }

        public void Update(DurusTip item)
        {
            _durusTip.Update(item);
        }
    }
}
