using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using IsTakip.Entities.Classes.MalzemeClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.KalinlikClasses
{
	public class Kalinlik : BaseObject
	{
		[DisplayName("Tanım")]
		public string Tanim { get; set; }
		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }


		public ICollection<DepoEnvanter> DepoEnvanters { get; set; }
		public ICollection<AlinanIsler> AlinanIslers { get; set; }

		
	}
}
