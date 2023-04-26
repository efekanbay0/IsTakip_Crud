using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.BaseObjectClasses
{
	public class BaseObject
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
		public int Id { get; set; }



		[ScaffoldColumn(false)] 
		[Browsable(false)] 
		[DisplayName("Oluşturan Kullanıcı")]
		[StringLength(255)]
		public string? OlusturanKullanici { get; set; }



		[ScaffoldColumn(false)] 
		[DisplayName("Oluşturan Kullanıcı Id")]
		public int OlusturanKullaniciId { get; set; }



		[ScaffoldColumn(false)]
		public string? GuncelleyenKullanici { get; set; }


		[ScaffoldColumn(false)]
		public int GuncelleyenKullaniciId { get; set; }



		[ScaffoldColumn(false)]
		public DateTime OlusturmaTarihi { get; set; }



		[ScaffoldColumn(false)]
		public DateTime GuncellemeTarihi { get; set; }



		[ScaffoldColumn(false)]
		public bool Aktif { get; set; }





		[DisplayName("Durum(Aktif/Pasif)")]
		public string AktifString => Aktif ? "Aktif" : "Pasif";



	}
}
