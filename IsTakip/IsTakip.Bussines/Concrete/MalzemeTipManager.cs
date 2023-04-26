using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MalzemeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MalzemeTipManager : IMalzemeTipService
    {
        IMalzemeTipDal _malzemeTip;

        public MalzemeTipManager(IMalzemeTipDal malzemeTip)
        {
            _malzemeTip = malzemeTip;
        }

        public void Delete(MalzemeTip item)
        {
            _malzemeTip.Delete(item);
        }

        public List<MalzemeTip> GetAll()
        {
            return _malzemeTip.GetAll();
        }

		public MalzemeTip GetById(int id)
		{
			return _malzemeTip.GetById(id);
		}

		public void Insert(MalzemeTip item)
        {
            _malzemeTip.Insert(item);
        }

        public List<MalzemeTip> List(Expression<Func<MalzemeTip, bool>> Filter)
        {
            return _malzemeTip.List(Filter);
        }

        public void Update(MalzemeTip item)
        {
            _malzemeTip.Update(item);
        }
    }
}
