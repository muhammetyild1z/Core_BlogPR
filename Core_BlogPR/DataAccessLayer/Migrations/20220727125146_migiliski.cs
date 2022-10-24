using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migiliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "catagoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_catagoryID",
                table: "Blogs",
                column: "catagoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Catagoies_catagoryID",
                table: "Blogs",
                column: "catagoryID",
                principalTable: "Catagoies",
                principalColumn: "catagoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Catagoies_catagoryID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_catagoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "catagoryID",
                table: "Blogs");
        }
    }
}
