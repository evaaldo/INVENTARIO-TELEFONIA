using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    public partial class AdicionarTabelaNotaFiscal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotasFiscais",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroNF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNF = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Soma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscais", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasFiscais");
        }
    }
}
