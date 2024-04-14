using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    public partial class CreateTabelaInventarioAparelho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventariosTelfonia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeloAparelho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAquisicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDesativacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mantenedora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosTelfonia", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventariosTelfonia");
        }
    }
}
