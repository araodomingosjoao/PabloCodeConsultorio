using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class RenomendoTabelaProfissionais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consultas_profissionais_id_profissional",
                table: "tb_consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_profissionais",
                table: "profissionais");

            migrationBuilder.RenameTable(
                name: "profissionais",
                newName: "tb_profissionais");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_profissionais",
                table: "tb_profissionais",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consultas_tb_profissionais_id_profissional",
                table: "tb_consultas",
                column: "id_profissional",
                principalTable: "tb_profissionais",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consultas_tb_profissionais_id_profissional",
                table: "tb_consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_profissionais",
                table: "tb_profissionais");

            migrationBuilder.RenameTable(
                name: "tb_profissionais",
                newName: "profissionais");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profissionais",
                table: "profissionais",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consultas_profissionais_id_profissional",
                table: "tb_consultas",
                column: "id_profissional",
                principalTable: "profissionais",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
