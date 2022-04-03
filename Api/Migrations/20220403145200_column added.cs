using Microsoft.EntityFrameworkCore.Migrations;

namespace Finance_Api.Migrations
{
    public partial class columnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "UserRegistration",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "UserRegistration");
        }
    }
}
