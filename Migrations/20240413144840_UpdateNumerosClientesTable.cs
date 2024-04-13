using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    public partial class UpdateNumerosClientesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desativacao",
                table: "NumerosClientes");

            migrationBuilder.AlterColumn<string>(
                name: "Virtual",
                table: "NumerosClientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtivacao",
                table: "NumerosClientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDesativacao",
                table: "NumerosClientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtivacao",
                table: "NumerosClientes");

            migrationBuilder.DropColumn(
                name: "DataDesativacao",
                table: "NumerosClientes");

            migrationBuilder.AlterColumn<bool>(
                name: "Virtual",
                table: "NumerosClientes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Desativacao",
                table: "NumerosClientes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
