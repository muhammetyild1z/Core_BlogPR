using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migiliski_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "blogID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_blogID",
                table: "Comments",
                column: "blogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_blogID",
                table: "Comments",
                column: "blogID",
                principalTable: "Blogs",
                principalColumn: "blogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_blogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_blogID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "blogID",
                table: "Comments");
        }
    }
}
