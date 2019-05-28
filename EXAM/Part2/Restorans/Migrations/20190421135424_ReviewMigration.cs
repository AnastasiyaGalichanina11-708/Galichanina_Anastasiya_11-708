using Microsoft.EntityFrameworkCore.Migrations;

namespace Restorans.Migrations
{
    public partial class ReviewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeclineComment",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeclineComment",
                table: "Recipes");
        }
    }
}
