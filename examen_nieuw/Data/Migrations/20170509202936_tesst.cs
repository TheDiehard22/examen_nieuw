using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_nieuw.Data.Migrations
{
    public partial class tesst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MinVoorraad",
                table: "ProductLocations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "aantal",
                table: "ProductLocations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinVoorraad",
                table: "ProductLocations");

            migrationBuilder.DropColumn(
                name: "aantal",
                table: "ProductLocations");
        }
    }
}
