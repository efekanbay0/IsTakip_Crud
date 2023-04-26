using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.MusteriKisitlamaClasses
{
	public class MusteriKisitlama : BaseObject
	{
		[DisplayName("İşlem Açıklama")]
		public string IslemAciklama { get; set; }

		[DisplayName("Kısıtlama")]
		public bool Kisitlama { get; set; }

		[DisplayName("Müşteri No")]
		public int MusteriId { get; set; }

		public virtual Musteri Musteri { get; set; }
	}
}
