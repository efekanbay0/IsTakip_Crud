using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.MusteriSinifClasses
{
	public class MusteriSinif : BaseObject
	{
		[DisplayName("Tanım")]
		[StringLength(255)]
		public string Tanim { get; set; }

		[DisplayName("Açıklama")]
		[StringLength(255)]
		public string Aciklama { get; set; }

		public ICollection<Musteri> Musteriler { get; set; }
	}
}
