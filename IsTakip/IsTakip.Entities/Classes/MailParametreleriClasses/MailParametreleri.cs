using IsTakip.Entities.Classes.BaseObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.MailParametreleriClasses
{
	public class MailParametreleri : BaseObject
	{
		public string SenderName { get; set; }
		public string EMail { get; set; }
		public string Sifre { get; set; }
		public string SmtpAdres { get; set; }
		public string SmtpPort { get; set; }
		public bool SSLKullan { get; set; }
	}
}
