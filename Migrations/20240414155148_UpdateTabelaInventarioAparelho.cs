using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    public partial class UpdateTabelaInventarioAparelho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InventariosTelfonia",
                table: "InventariosTelfonia");

            migrationBuilder.RenameTable(
                name: "InventariosTelfonia",
                newName: "InventariosAparelho");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventariosAparelho",
                table: "InventariosAparelho",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InventariosAparelho",
                table: "InventariosAparelho");

            migrationBuilder.RenameTable(
                name: "InventariosAparelho",
                newName: "InventariosTelfonia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventariosTelfonia",
                table: "InventariosTelfonia",
                column: "ID");
        }
    }
}
