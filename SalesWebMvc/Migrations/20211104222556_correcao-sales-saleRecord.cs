using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class CorrecaosalessaleRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Seller",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Seller",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "Nome");
        }
    }
}
