using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.MusteriTemsilciClasses
{
	public class MusteriTemsilci : BaseObject
	{
		[DisplayName("Ad")]
		public string Ad { get; set; }
		[DisplayName("Soyad")]
		public string Soyad { get; set; }

		public string EMail { get; set; }

		[DisplayName("Telefon No")]
		public string TelefonNumarasi { get; set; }

		[ForeignKey("Musteri")]
		public int MusteriId { get; set; }
		public virtual Musteri Musteri { get; set; }
	}
}
