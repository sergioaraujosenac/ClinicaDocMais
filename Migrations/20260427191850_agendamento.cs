using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDocMais.Migrations
{
    /// <inheritdoc />
    public partial class agendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "especialidadeMedic",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "nomeMedico",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "nomePaciente",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "telefonePaciente",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "cpfpaciente",
                table: "Agendamentos",
                newName: "cpfPaciente");

            migrationBuilder.AddColumn<string>(
                name: "MediconumerodocrmMedico",
                table: "Agendamentos",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "pacientecpf",
                table: "Agendamentos",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_MediconumerodocrmMedico",
                table: "Agendamentos",
                column: "MediconumerodocrmMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_pacientecpf",
                table: "Agendamentos",
                column: "pacientecpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Medicos_MediconumerodocrmMedico",
                table: "Agendamentos",
                column: "MediconumerodocrmMedico",
                principalTable: "Medicos",
                principalColumn: "numerodocrmMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Pacientes_pacientecpf",
                table: "Agendamentos",
                column: "pacientecpf",
                principalTable: "Pacientes",
                principalColumn: "cpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Medicos_MediconumerodocrmMedico",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Pacientes_pacientecpf",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_MediconumerodocrmMedico",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_pacientecpf",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "MediconumerodocrmMedico",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "pacientecpf",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "cpfPaciente",
                table: "Agendamentos",
                newName: "cpfpaciente");

            migrationBuilder.AddColumn<string>(
                name: "especialidadeMedic",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nomeMedico",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nomePaciente",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "telefonePaciente",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
