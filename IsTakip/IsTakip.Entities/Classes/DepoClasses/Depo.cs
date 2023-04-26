using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using IsTakip.Entities.Classes.DepoRafClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.DepoClasses
{
	public class Depo : BaseObject
	{
		[DisplayName("Tanımı")]
		public string Tanim { get; set; }

		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }

		[DisplayName("Yetkili")]
		public string Yetkili { get; set; }

		[DisplayName("Yetkili Telefon No")]
		public string YetkiliTelefon { get; set; }


		public virtual ICollection<DepoEnvanter> DepoEnvanter { get; set; }







		

		
		
	}
}