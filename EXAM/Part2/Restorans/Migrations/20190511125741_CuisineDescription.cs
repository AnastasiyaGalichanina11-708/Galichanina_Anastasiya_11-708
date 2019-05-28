using Microsoft.EntityFrameworkCore.Migrations;

namespace Restorans.Migrations
{
    public partial class CuisineDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cuisines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cuisines");
        }
    }
}
