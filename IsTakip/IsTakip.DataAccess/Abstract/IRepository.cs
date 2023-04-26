using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Abstract
{
	public interface IRepository <T>
	{
		List<T> GetAll ();
		void Insert (T item);
		void Update (T item);
		void Delete (T item);
        T GetById (int id);
        List<T> List(Expression<Func<T, bool>> Filter);

	}
}
