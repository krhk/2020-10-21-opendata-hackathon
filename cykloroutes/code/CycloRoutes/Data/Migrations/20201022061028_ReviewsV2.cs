using Microsoft.EntityFrameworkCore.Migrations;

namespace CycloRoutes.Data.Migrations
{
    public partial class ReviewsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Review",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Review");
        }
    }
}
