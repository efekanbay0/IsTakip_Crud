using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.DepoRafClasses
{
	public class DepoRaf : BaseObject
	{
		[DisplayName("Depo Raf Tanım")]
		public string Tanim { get; set; }

		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }

		

		public virtual DepoEnvanter DepoEnvanter { get; set; }
	}
}