using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.IsDosyaClasses
{
	public class IsDosya : BaseObject
	{
		[DisplayName("Alinan İş No")]
		public int AlinanIslerId { get; set; }

		[DisplayName("Dosya Adı")]
		public string DosyaAdi { get; set; }


		public virtual AlinanIsler AlinanIslers { get; set; }

		
	}
}
