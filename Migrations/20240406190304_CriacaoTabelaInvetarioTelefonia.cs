using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    public partial class CriacaoTabelaInvetarioTelefonia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuariosTelefonia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentoPessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICCID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Operadora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventarioAparelho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosTelefonia", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosTelefonia");
        }
    }
}
