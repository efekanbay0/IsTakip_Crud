using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DurusTipClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.UretimDurusClasses
{
	public class UretimDurus : BaseObject
	{

		
		[DisplayName("Üretim Emri No")]
		public int UretimEmriId { get; set; }

		[DisplayName("Duruş Süresi")]
		public DateTime DurusSuresi { get; set; }
		

		[DisplayName("Duruş No")]
		public int DurusTipId { get; set; }
				
		public virtual UretimEmri UretimEmri { get; set; }
		public virtual DurusTip DurusTips { get; set; }
	}
}
