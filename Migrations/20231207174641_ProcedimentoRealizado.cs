using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalBruno.Migrations
{
    public partial class ProcedimentoRealizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ObersevacaoRealizacao",
                table: "ProcedimentoRealizado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObersevacaoRealizacao",
                table: "ProcedimentoRealizado");
        }
    }
}
