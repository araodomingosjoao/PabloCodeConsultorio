using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class Relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_paciente",
                table: "tb_consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_consultas_id_paciente",
                table: "tb_consultas",
                column: "id_paciente");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consultas_tb_pacientes_id_paciente",
                table: "tb_consultas",
                column: "id_paciente",
                principalTable: "tb_pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consultas_tb_pacientes_id_paciente",
                table: "tb_consultas");

            migrationBuilder.DropIndex(
                name: "IX_tb_consultas_id_paciente",
                table: "tb_consultas");

            migrationBuilder.DropColumn(
                name: "id_paciente",
                table: "tb_consultas");
        }
    }
}
