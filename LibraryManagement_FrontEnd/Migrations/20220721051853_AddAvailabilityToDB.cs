using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement_FrontEnd.Migrations
{
    public partial class AddAvailabilityToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableCount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableCount",
                table: "Books");
        }
    }
}
