using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement_FrontEnd.Migrations
{
    public partial class AddLendBookStatusToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "LendRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "LendRequests");
        }
    }
}
