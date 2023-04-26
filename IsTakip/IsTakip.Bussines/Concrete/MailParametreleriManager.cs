using IsTakip.Bussines.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities.Classes.MailParametreleriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Bussines.Concrete
{
    public class MailParametreleriManager : IMailParametreleriService
    {
        IMailParametreleriDal _mailParametreleri;

        public MailParametreleriManager(IMailParametreleriDal mailParametreleri)
        {
            _mailParametreleri = mailParametreleri;
        }

        public void Delete(MailParametreleri item)
        {
            _mailParametreleri.Delete(item);
        }

        public List<MailParametreleri> GetAll()
        {
            return _mailParametreleri.GetAll();
        }

		public MailParametreleri GetById(int id)
		{
			return _mailParametreleri.GetById(id);
		}

		public void Insert(MailParametreleri item)
        {
            _mailParametreleri.Insert(item);
        }

        public List<MailParametreleri> List(Expression<Func<MailParametreleri, bool>> Filter)
        {
           return _mailParametreleri.List(Filter);
        }

        public void Update(MailParametreleri item)
        {
            _mailParametreleri.Update(item);
        }
    }
}
