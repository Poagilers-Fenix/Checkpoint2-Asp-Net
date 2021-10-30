using Microsoft.EntityFrameworkCore.Migrations;

namespace fiap.webapp.check2.hospital.Migrations
{
    public partial class BancoDBN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes",
                column: "HospitalId",
                principalTable: "Hospitais",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Pacientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes",
                column: "HospitalId",
                principalTable: "Hospitais",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
