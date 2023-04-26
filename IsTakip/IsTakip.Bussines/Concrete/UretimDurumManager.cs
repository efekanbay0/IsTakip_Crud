using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.UretimDrumClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class UretimDurumManager : IUretimDrumService
    {
        IUretimDurumDal _uretimDurum;

        public UretimDurumManager(IUretimDurumDal uretimDurum)
        {
            _uretimDurum = uretimDurum;
        }

        public void Delete(UretimDurum item)
        {
            _uretimDurum.Delete(item);
        }

        public List<UretimDurum> GetAll()
        {
            return _uretimDurum.GetAll();
        }

		public UretimDurum GetById(int id)
		{
			return _uretimDurum.GetById(id);
		}

		public void Insert(UretimDurum item)
        {
            _uretimDurum.Insert(item);
        }

        public List<UretimDurum> List(Expression<Func<UretimDurum, bool>> Filter)
        {
            return _uretimDurum.List(Filter);
        }

        public void Update(UretimDurum item)
        {
           _uretimDurum.Update(item);
        }
    }
}
