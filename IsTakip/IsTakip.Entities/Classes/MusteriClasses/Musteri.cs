using IsTakip.Entities.Classes.AjandaClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using IsTakip.Entities.Classes.KullaniciClasses;
using IsTakip.Entities.Classes.MusteriSinifClasses;
using IsTakip.Entities.Classes.MusteriTemsilciClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsTakip.Entities.Classes.MusteriKisitlamaClasses;
using IsTakip.Entities.Classes.AlinanIslerClasses;

namespace IsTakip.Entities.Classes.MusteriClasses
{
	public class Musteri : BaseObject
	{
		[DisplayName("Tanim")]
		public string Tanim { get; set; }

		[DisplayName("Musteri Sinif Id")]
		public int? MusteriSinifId { get; set; }

		[DisplayName("Adres")]
		public string Adres { get; set; }

		[DisplayName("Telefon")]
		public string Telefon { get; set; }
		public string EMail { get; set; }

		[DisplayName("Vergi Dairesi")]
		public string VergiDairesi { get; set; }

		[DisplayName("Vergi Dairesi Numarasi")]
		public int VergiDairesiNumarasi { get; set; }

		[DisplayName("Aciklama")]
		public string Aciklama { get; set; }

		public virtual MusteriSinif? MusteriSinif { get; set; }

		public ICollection<Ajanda>? Ajanda { get; set; }
		public ICollection<MusteriKisitlama>? kisitlama { get; set; }		
		public ICollection <MusteriTemsilci>? MusteriTemsilci { get; set; }		
		public ICollection<Kullanici>? Kullanici { get; set; }		
		public ICollection <AlinanIsler>? AlinanIsler { get; set; }
		public virtual ICollection<DepoEnvanter>? DepoEnvanter { get; set; }


	}
}
