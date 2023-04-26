using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.IsDosyaClasses;
using IsTakip.Entities.Classes.UretimDrumClasses;
using IsTakip.Entities.Classes.UretimDurusClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.UretimEmriClasses
{
	public class UretimEmri : BaseObject
	{

		
		

		[DisplayName("Alınan İşler")]
		public int AilnanIslerId { get; set; }

		[DisplayName("İş Emri Tarihi")]
		public DateTime IsEmriTarihi { get; set; }
		[DisplayName("Toplam Duruş Süresi")]
		public DateTime ToplamDurusSuresi { get; set; }

		[DisplayName("Üretim Başlama Tarihi")]
		public DateTime? UretimBaslamaTarihi { get; set; }

		[DisplayName("Üretim Tamamlama Tarihi")]
		public DateTime? UretimTamamlanmaTarihi { get; set; }

		[DisplayName("Uretim Durumu")]
		public int UretimDrumId { get; set; }

		public virtual AlinanIsler AlinanIsler { get; set; }
		public virtual UretimDurum UretimDurums { get; set; }

		

	}
}
