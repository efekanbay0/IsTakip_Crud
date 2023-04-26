using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Abstract
{
    public interface IGenericService<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
		T GetById(int id);
		List<T> GetAll();
        List<T> List(Expression<Func<T, bool>> Filter);
    }
}
