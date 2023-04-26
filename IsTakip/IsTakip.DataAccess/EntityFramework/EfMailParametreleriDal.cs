using IsTakip.DataAccess.Abstract;
using IsTakip.DataAccess.Concrete;
using IsTakip.Entities.Classes.MailParametreleriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.EntityFramework
{
	public class EfMailParametreleriDal : GenericRepository<MailParametreleri>, IMailParametreleriDal
	{
	}
}
