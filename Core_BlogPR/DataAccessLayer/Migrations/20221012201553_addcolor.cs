using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addcolor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aboutStatus",
                table: "notifications");

            migrationBuilder.AddColumn<string>(
                name: "NotificationColor",
                table: "notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationColor",
                table: "notifications");

            migrationBuilder.AddColumn<bool>(
                name: "aboutStatus",
                table: "notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
