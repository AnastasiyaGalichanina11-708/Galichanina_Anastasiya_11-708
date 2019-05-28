using Microsoft.EntityFrameworkCore.Migrations;

namespace Restorans.Migrations
{
    public partial class DateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreationDate",
                table: "Recipes",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Recipes");
        }
    }
}
