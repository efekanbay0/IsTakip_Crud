using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.AjandaClasses
{
	public class Ajanda : BaseObject
	{
		[DisplayName("Müşteri Numarası")]
		public int MusteriId { get; set; }


		[DisplayName("Açıklama")]
		[StringLength(255)]
		public string? Aciklama { get; set; }

		[DisplayName("Kayıt Edilen Tarih")]
		public DateTime NotTarihi { get; set; }

		public virtual Musteri Musteri { get; set; }
	}
}
