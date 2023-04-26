using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.KullaniciClasses
{
	public class Kullanici : BaseObject
	{
		[DisplayName("Ad")]
		public string Ad { get; set; }

		[DisplayName("Soyad")]
		public string Soyad { get; set; }

		[DisplayName("Müşteri No")]
		public int MusteriId { get; set; }

		public virtual Musteri Musteri { get; set; }

		[DisplayName("Kullanıcı Adı")]
		public int KullaniciKodu { get; set; }

		[DisplayName("Şifre")]
		public string KullaniciSifre { get; set; }

		[DisplayName("Mail Bildirimi")]
		public bool MailBildirimi { get; set; }

		[DisplayName("Rol Tanım")]
		public string RolTanim { get; set; }

		
	}
}
