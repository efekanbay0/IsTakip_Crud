using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.IsDosyaClasses;
using IsTakip.Entities.Classes.IsOnceligiClasses;
using IsTakip.Entities.Classes.KalinlikClasses;
using IsTakip.Entities.Classes.MalzemeClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.AlinanIslerClasses
{
	public class AlinanIsler : BaseObject
	{
		
		[DisplayName("Müşteri No")]
		public int MusteriId { get; set; }


		[DisplayName("Teklif")]
		public bool Teklifli { get; set; }

		[DisplayName("Teklif No")]
		public int TeklifNo { get; set; }

		public int Fiyat { get; set; }

		[DisplayName("İş Bitimi")]
		public bool IsBitimindeBildir { get; set; }
		public string Termin { get; set; }

		[DisplayName("Müşteri Sipariş No")]
		public int MusteriSiparisNo { get; set; }

		[DisplayName("İş Notu")]
		public string IsNotu { get; set; }

		[DisplayName("Malzeme Tip No")]
		public int MalzemeTipId { get; set; }

		[DisplayName("Malzeme Kalınlık No")]
		public int KalinlikId { get; set; }

		[DisplayName("İşçilik")]
		public bool Iscilik { get; set; }


		[DisplayName("Malzeme Notu")]
		public string MalzemeNotu { get; set; }	

		
		public virtual Musteri musteris { get; set; }
		public virtual MalzemeTip MalzemeTips { get; set; }
		public virtual Kalinlik Kalinliks { get; set; }
			

		public ICollection <UretimEmri> UretimEmris { get; set; }
		public  ICollection<IsDosya> ısDosyas { get; set; }
		public  ICollection<IsOnceligi> IsOnceligis { get; set; }

	}
}
