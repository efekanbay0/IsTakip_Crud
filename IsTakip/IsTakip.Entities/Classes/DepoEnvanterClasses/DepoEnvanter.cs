using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoClasses;
using IsTakip.Entities.Classes.DepoRafClasses;
using IsTakip.Entities.Classes.KalinlikClasses;
using IsTakip.Entities.Classes.MalzemeClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.DepoEnvanterClasses
{
	public class DepoEnvanter : BaseObject
	{

		[DisplayName("Depo No")]
		public int DepoId { get; set; }

		[DisplayName("Depo Raf No")]
		public int DepoRafId { get; set; }

		[DisplayName("Musteri No")]
		public  int MusteriId { get; set; }

		[DisplayName("Malzeme Tip No")]
		public int MalzemeTipId { get; set; }
		[DisplayName("Kalınlık No")]
		public int KalinlikId { get; set; }


		public float En { get; set; }
		public float Boy { get; set; }
		public int Adet { get; set; }

		[DisplayName("Ağırlık")]
		public float Agirlik { get; set; }

		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }


		public virtual Musteri musteri { get; set; }
		public virtual Depo Depo { get; set; }
		public virtual MalzemeTip malzemeTip { get; set; }
		public virtual Kalinlik Kalinlik { get; set; }
		public virtual DepoRaf DepoRaf { get; set; }



		
		
		

	}
}