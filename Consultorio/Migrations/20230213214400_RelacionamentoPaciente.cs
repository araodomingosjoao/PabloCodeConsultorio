using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class RelacionamentoPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_especialidade",
                table: "tb_consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_profissional",
                table: "tb_consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_consultas_id_especialidade",
                table: "tb_consultas",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_tb_consultas_id_profissional",
                table: "tb_consultas",
                column: "id_profissional");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consultas_profissionais_id_profissional",
                table: "tb_consultas",
                column: "id_profissional",
                principalTable: "profissionais",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consultas_tb_especialidades_id_especialidade",
                table: "tb_consultas",
                column: "id_especialidade",
                principalTable: "tb_especialidades",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consultas_profissionais_id_profissional",
                table: "tb_consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consultas_tb_especialidades_id_especialidade",
                table: "tb_consultas");

            migrationBuilder.DropIndex(
                name: "IX_tb_consultas_id_especialidade",
                table: "tb_consultas");

            migrationBuilder.DropIndex(
                name: "IX_tb_consultas_id_profissional",
                table: "tb_consultas");

            migrationBuilder.DropColumn(
                name: "id_especialidade",
                table: "tb_consultas");

            migrationBuilder.DropColumn(
                name: "id_profissional",
                table: "tb_consultas");
        }
    }
}
