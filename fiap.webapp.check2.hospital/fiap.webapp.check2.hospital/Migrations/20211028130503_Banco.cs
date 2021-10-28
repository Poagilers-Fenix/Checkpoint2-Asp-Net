using Microsoft.EntityFrameworkCore.Migrations;

namespace fiap.webapp.check2.hospital.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoencaPaciente_Doenca_DoencaId",
                table: "DoencaPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_DoencaPaciente_Paciente_PacientesPacienteId",
                table: "DoencaPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospital_Endereco_EnderecoId",
                table: "Hospital");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Endereco_EnderecoId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Hospital_HospitalId",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doenca",
                table: "Doenca");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Hospital",
                newName: "Hospitais");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Doenca",
                newName: "Doencas");

            migrationBuilder.RenameIndex(
                name: "IX_Paciente_HospitalId",
                table: "Pacientes",
                newName: "IX_Pacientes_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Paciente_EnderecoId",
                table: "Pacientes",
                newName: "IX_Pacientes_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospital_EnderecoId",
                table: "Hospitais",
                newName: "IX_Hospitais_EnderecoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pacientes",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Pacientes",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Hospitais",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Capacidade",
                table: "Hospitais",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Enderecos",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Enderecos",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sintomas",
                table: "Doencas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Doencas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "PacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospitais",
                table: "Hospitais",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doencas",
                table: "Doencas",
                column: "DoencaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoencaPaciente_Doencas_DoencaId",
                table: "DoencaPaciente",
                column: "DoencaId",
                principalTable: "Doencas",
                principalColumn: "DoencaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoencaPaciente_Pacientes_PacientesPacienteId",
                table: "DoencaPaciente",
                column: "PacientesPacienteId",
                principalTable: "Pacientes",
                principalColumn: "PacienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitais_Enderecos_EnderecoId",
                table: "Hospitais",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Enderecos_EnderecoId",
                table: "Pacientes",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes",
                column: "HospitalId",
                principalTable: "Hospitais",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoencaPaciente_Doencas_DoencaId",
                table: "DoencaPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_DoencaPaciente_Pacientes_PacientesPacienteId",
                table: "DoencaPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitais_Enderecos_EnderecoId",
                table: "Hospitais");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Enderecos_EnderecoId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Hospitais_HospitalId",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospitais",
                table: "Hospitais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doencas",
                table: "Doencas");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Paciente");

            migrationBuilder.RenameTable(
                name: "Hospitais",
                newName: "Hospital");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Doencas",
                newName: "Doenca");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_HospitalId",
                table: "Paciente",
                newName: "IX_Paciente_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_EnderecoId",
                table: "Paciente",
                newName: "IX_Paciente_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitais_EnderecoId",
                table: "Hospital",
                newName: "IX_Hospital_EnderecoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Hospital",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Capacidade",
                table: "Hospital",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Sintomas",
                table: "Doenca",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Doenca",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "PacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doenca",
                table: "Doenca",
                column: "DoencaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoencaPaciente_Doenca_DoencaId",
                table: "DoencaPaciente",
                column: "DoencaId",
                principalTable: "Doenca",
                principalColumn: "DoencaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoencaPaciente_Paciente_PacientesPacienteId",
                table: "DoencaPaciente",
                column: "PacientesPacienteId",
                principalTable: "Paciente",
                principalColumn: "PacienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Endereco_EnderecoId",
                table: "Hospital",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Endereco_EnderecoId",
                table: "Paciente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Hospital_HospitalId",
                table: "Paciente",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
