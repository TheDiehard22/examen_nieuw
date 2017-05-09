using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_nieuw.Data.Migrations
{
    public partial class tesstt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocations_Products_ProductID",
                table: "ProductLocations");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ProductLocations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocations_Products_ProductID",
                table: "ProductLocations",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocations_Products_ProductID",
                table: "ProductLocations");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ProductLocations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocations_Products_ProductID",
                table: "ProductLocations",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
