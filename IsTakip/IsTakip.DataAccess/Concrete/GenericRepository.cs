using IsTakip.DataAccess.Abstract;
using IsTakip.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		public void Delete(T item)
		{
			using var c = new DataContext();
			c.Remove(item);
			c.SaveChanges();
		}

		public List<T> GetAll()
		{
			using var c = new DataContext();
			return c.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			using var c = new DataContext();
			return c.Set<T>().Find(id); 
		}

		public void Insert(T item)
		{
			using var c = new DataContext(); 
			c.Add(item);
			c.SaveChanges();
		}

		public List<T> List(Expression<Func<T, bool>> Filter)
		{
			using var c = new DataContext();
			return c.Set<T>().Where(Filter).ToList();
		}

		public void Update(T item)
		{
			using var c = new DataContext();
			c.Update(item);
			c.SaveChanges();
		}
	}
}
