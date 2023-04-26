using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.DataAccess.Migrations
{
    public partial class _1001firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deporafs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deporafs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DurusTips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurusTips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailParametreleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSLKullan = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailParametreleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "malzemeTips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_malzemeTips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSınıfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSınıfs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UretimDurums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDurums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kalinliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kalinliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kalinliks_malzemeTips_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "malzemeTips",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tedarikcis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipsId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikcis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tedarikcis_malzemeTips_MalzemeTipsId",
                        column: x => x.MalzemeTipsId,
                        principalTable: "malzemeTips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesiNumarasi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_musteris_MusteriSınıfs_MusteriSinifId",
                        column: x => x.MusteriSinifId,
                        principalTable: "MusteriSınıfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ajandas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NotTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajandas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ajandas_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlinanIslers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Teklifli = table.Column<bool>(type: "bit", nullable: false),
                    TeklifNo = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<int>(type: "int", nullable: false),
                    IsBitimindeBildir = table.Column<bool>(type: "bit", nullable: false),
                    Termin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSiparisNo = table.Column<int>(type: "int", nullable: false),
                    IsNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    Iscilik = table.Column<bool>(type: "bit", nullable: false),
                    MalzemeNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlinanIslers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlinanIslers_kalinliks_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "kalinliks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlinanIslers_malzemeTips_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "malzemeTips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlinanIslers_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepoEnvanters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    En = table.Column<float>(type: "real", nullable: false),
                    Boy = table.Column<float>(type: "real", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<float>(type: "real", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoEnvanters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoEnvanters_Deporafs_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "Deporafs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanters_Depos_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanters_kalinliks_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "kalinliks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanters_malzemeTips_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "malzemeTips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanters_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    KullaniciKodu = table.Column<int>(type: "int", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailBildirimi = table.Column<bool>(type: "bit", nullable: false),
                    RolTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicis_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriKisitlamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisitlama = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKisitlamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriKisitlamas_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTemsilcis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTemsilcis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriTemsilcis_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsDosyas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanIslerId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDosyas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDosyas_AlinanIslers_AlinanIslerId",
                        column: x => x.AlinanIslerId,
                        principalTable: "AlinanIslers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsOnceligis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlinanIslerId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsOnceligis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsOnceligis_AlinanIslers_AlinanIslerId",
                        column: x => x.AlinanIslerId,
                        principalTable: "AlinanIslers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimEmris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AilnanIslerId = table.Column<int>(type: "int", nullable: false),
                    IsEmriTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamDurusSuresi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UretimBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimTamamlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimDrumId = table.Column<int>(type: "int", nullable: false),
                    AlinanIslerId = table.Column<int>(type: "int", nullable: false),
                    UretimDurumsId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimEmris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimEmris_AlinanIslers_AlinanIslerId",
                        column: x => x.AlinanIslerId,
                        principalTable: "AlinanIslers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UretimEmris_UretimDurums_UretimDurumsId",
                        column: x => x.UretimDurumsId,
                        principalTable: "UretimDurums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimDurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimEmriId = table.Column<int>(type: "int", nullable: false),
                    DurusSuresi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurusTipId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDurus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDurus_DurusTips_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UretimDurus_UretimEmris_UretimEmriId",
                        column: x => x.UretimEmriId,
                        principalTable: "UretimEmris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ajandas_MusteriId",
                table: "Ajandas",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_AlinanIslers_KalinlikId",
                table: "AlinanIslers",
                column: "KalinlikId");

            migrationBuilder.CreateIndex(
                name: "IX_AlinanIslers_MalzemeTipId",
                table: "AlinanIslers",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_AlinanIslers_MusteriId",
                table: "AlinanIslers",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanters_DepoId",
                table: "DepoEnvanters",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanters_DepoRafId",
                table: "DepoEnvanters",
                column: "DepoRafId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanters_KalinlikId",
                table: "DepoEnvanters",
                column: "KalinlikId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanters_MalzemeTipId",
                table: "DepoEnvanters",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanters_MusteriId",
                table: "DepoEnvanters",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_IsDosyas_AlinanIslerId",
                table: "IsDosyas",
                column: "AlinanIslerId");

            migrationBuilder.CreateIndex(
                name: "IX_IsOnceligis_AlinanIslerId",
                table: "IsOnceligis",
                column: "AlinanIslerId");

            migrationBuilder.CreateIndex(
                name: "IX_kalinliks_MalzemeTipId",
                table: "kalinliks",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_MusteriId",
                table: "Kullanicis",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKisitlamas_MusteriId",
                table: "MusteriKisitlamas",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_musteris_MusteriSinifId",
                table: "musteris",
                column: "MusteriSinifId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriTemsilcis_MusteriId",
                table: "MusteriTemsilcis",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikcis_MalzemeTipsId",
                table: "Tedarikcis",
                column: "MalzemeTipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_DurusTipId",
                table: "UretimDurus",
                column: "DurusTipId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_UretimEmriId",
                table: "UretimDurus",
                column: "UretimEmriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimEmris_AlinanIslerId",
                table: "UretimEmris",
                column: "AlinanIslerId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimEmris_UretimDurumsId",
                table: "UretimEmris",
                column: "UretimDurumsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajandas");

            migrationBuilder.DropTable(
                name: "DepoEnvanters");

            migrationBuilder.DropTable(
                name: "IsDosyas");

            migrationBuilder.DropTable(
                name: "IsOnceligis");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "MailParametreleris");

            migrationBuilder.DropTable(
                name: "MusteriKisitlamas");

            migrationBuilder.DropTable(
                name: "MusteriTemsilcis");

            migrationBuilder.DropTable(
                name: "Tedarikcis");

            migrationBuilder.DropTable(
                name: "UretimDurus");

            migrationBuilder.DropTable(
                name: "Deporafs");

            migrationBuilder.DropTable(
                name: "Depos");

            migrationBuilder.DropTable(
                name: "DurusTips");

            migrationBuilder.DropTable(
                name: "UretimEmris");

            migrationBuilder.DropTable(
                name: "AlinanIslers");

            migrationBuilder.DropTable(
                name: "UretimDurums");

            migrationBuilder.DropTable(
                name: "kalinliks");

            migrationBuilder.DropTable(
                name: "musteris");

            migrationBuilder.DropTable(
                name: "malzemeTips");

            migrationBuilder.DropTable(
                name: "MusteriSınıfs");
        }
    }
}
