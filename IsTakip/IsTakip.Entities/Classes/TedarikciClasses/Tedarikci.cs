using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MalzemeClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.TedarikciClasses
{
	public class Tedarikci : BaseObject
	{
		[DisplayName("Tanım")]
		public string Tanim { get; set; }

		[DisplayName("Telefon")]
		public string Telefon { get; set; }
		public string EMail { get; set; }

		[DisplayName("Açıklama")]
		public string Aciklama { get; set; }

		[DisplayName("Malzeme No")]
		public int MalzemeId { get; set; }

		public virtual MalzemeTip MalzemeTips { get; set; }
	}
}
