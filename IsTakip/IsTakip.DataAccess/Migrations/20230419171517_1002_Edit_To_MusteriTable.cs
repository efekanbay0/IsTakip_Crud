using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.DataAccess.Migrations
{
    public partial class _1002_Edit_To_MusteriTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musteris_MusteriSınıfs_MusteriSinifId",
                table: "musteris");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriSinifId",
                table: "musteris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_musteris_MusteriSınıfs_MusteriSinifId",
                table: "musteris",
                column: "MusteriSinifId",
                principalTable: "MusteriSınıfs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musteris_MusteriSınıfs_MusteriSinifId",
                table: "musteris");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriSinifId",
                table: "musteris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_musteris_MusteriSınıfs_MusteriSinifId",
                table: "musteris",
                column: "MusteriSinifId",
                principalTable: "MusteriSınıfs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
