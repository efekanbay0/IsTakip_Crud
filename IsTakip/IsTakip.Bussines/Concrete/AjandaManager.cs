using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.AjandaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class AjandaManager : IAjandaService
    {
        IAjandaDal _AjandaDal;

        public AjandaManager(IAjandaDal ajandaDal)
        {
            _AjandaDal = ajandaDal;
        }

        public void Delete(Ajanda item)
        {
            _AjandaDal.Delete(item);    
        }

        public List<Ajanda> GetAll()
        {
            return _AjandaDal.GetAll();
        }

		public Ajanda GetById(int id)
		{
			return _AjandaDal.GetById(id);
		}

		public void Insert(Ajanda item)
        {
           _AjandaDal.Insert(item);
        }

        public List<Ajanda> List(Expression<Func<Ajanda, bool>> Filter)
        {
            return _AjandaDal.List(Filter);
        }

        public void Update(Ajanda item)
        {
           _AjandaDal.Update(item);
        }
    }
}
