using IsTakip.Entities.Classes.AjandaClasses;
using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.DepoClasses;
using IsTakip.Entities.Classes.DepoEnvanterClasses;
using IsTakip.Entities.Classes.DepoRafClasses;
using IsTakip.Entities.Classes.DurusTipClasses;
using IsTakip.Entities.Classes.IsDosyaClasses;
using IsTakip.Entities.Classes.IsOnceligiClasses;
using IsTakip.Entities.Classes.KalinlikClasses;
using IsTakip.Entities.Classes.KullaniciClasses;
using IsTakip.Entities.Classes.MailParametreleriClasses;
using IsTakip.Entities.Classes.MalzemeClasses;
using IsTakip.Entities.Classes.MusteriClasses;
using IsTakip.Entities.Classes.MusteriKisitlamaClasses;
using IsTakip.Entities.Classes.MusteriSinifClasses;
using IsTakip.Entities.Classes.MusteriTemsilciClasses;
using IsTakip.Entities.Classes.TedarikciClasses;
using IsTakip.Entities.Classes.UretimDrumClasses;
using IsTakip.Entities.Classes.UretimDurusClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Context
{
	public class DataContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=MERT; Database=IsTakip; User Id=sa; Password =123");
		}

		public DataContext()
		{
		}

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		


		public DbSet<Ajanda> Ajandas { get; set; }
		public DbSet<AlinanIsler> AlinanIslers { get; set; }
		public DbSet<Depo> Depos { get; set; }
		public DbSet<DepoEnvanter> DepoEnvanters { get; set; }
		public DbSet<DepoRaf> Deporafs { get; set; }
		public DbSet<DurusTip> DurusTips { get; set; }
		public DbSet<IsDosya> IsDosyas { get; set; }
		public DbSet<IsOnceligi> IsOnceligis { get; set; }
		public DbSet<Kalinlik> kalinliks { get; set; }
		public DbSet<Kullanici> Kullanicis { get; set; }
		public DbSet<MailParametreleri> MailParametreleris { get; set; }
		public DbSet<MalzemeTip> malzemeTips { get; set; }
		public DbSet<Musteri> musteris { get; set; }
		public DbSet<MusteriKisitlama> MusteriKisitlamas { get; set; }
		public DbSet<MusteriSinif> MusteriSınıfs { get; set; }
		public DbSet<MusteriTemsilci> MusteriTemsilcis { get; set; }
		public DbSet<Tedarikci> Tedarikcis { get; set; }
		public DbSet<UretimDurum> UretimDurums { get; set; }
		public DbSet<UretimDurus> UretimDurus { get; set; }
		public DbSet<UretimEmri> UretimEmris { get; set; }
	}
}
