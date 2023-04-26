using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
	public class UretimEmriManager : IUretimEmriService
	{
		IUretimEmriDal _uretimEmri;

		public UretimEmriManager(IUretimEmriDal uretimEmri)
		{
			_uretimEmri = uretimEmri;
		}

		public void Delete(UretimEmri item)
		{
			_uretimEmri.Delete(item);
		}

		public List<UretimEmri> GetAll()
		{
			return _uretimEmri.GetAll();
		}

		public UretimEmri GetById(int id)
		{
			return _uretimEmri.GetById(id);

		}

		public void Insert(UretimEmri item)
		{
			_uretimEmri.Insert(item);
		}

		public List<UretimEmri> List(Expression<Func<UretimEmri, bool>> Filter)
		{
			return _uretimEmri.List(Filter);
		}

		public void Update(UretimEmri item)
		{
			_uretimEmri.Update(item);
		}
	}
}
