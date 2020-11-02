using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CycloRoutes.Data.Migrations
{
    public partial class fix123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Review",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RoadRating",
                table: "Review",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "RoadRating",
                table: "Review");
        }
    }
}
