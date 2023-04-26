using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.DataAccess.Migrations
{
    public partial class _1004_BaseObject_Remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "UretimEmris");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "UretimDurus");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "UretimDurums");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Tedarikcis");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "MusteriTemsilcis");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "MusteriSınıfs");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "musteris");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "MusteriKisitlamas");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "malzemeTips");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "MailParametreleris");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "kalinliks");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "IsOnceligis");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "IsDosyas");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "DurusTips");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Deporafs");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "DepoEnvanters");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "AlinanIslers");

            migrationBuilder.DropColumn(
                name: "Silindi",
                table: "Ajandas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "UretimEmris",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "UretimDurus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "UretimDurums",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Tedarikcis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "MusteriTemsilcis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "MusteriSınıfs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "musteris",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "MusteriKisitlamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "malzemeTips",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "MailParametreleris",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Kullanicis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "kalinliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "IsOnceligis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "IsDosyas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "DurusTips",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Depos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Deporafs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "DepoEnvanters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "AlinanIslers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Silindi",
                table: "Ajandas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
