using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using IsTakip.Entities.Classes.KalinlikClasses;
using IsTakip.Entities.Classes.TedarikciClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.MalzemeClasses
{
	public class MalzemeTip : BaseObject
	{
		
		
		[DisplayName("Tanım")]
		public string Tanim { get; set; }

		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }
			
		public  ICollection<DepoEnvanter> DepoEnvanter { get; set; }
		public ICollection<Kalinlik> kalinliks { get; set; }
		public ICollection<AlinanIsler> AlinanIsler { get; set; }
		public ICollection<Tedarikci> Tedarikcis { get; set; }





	}
}
