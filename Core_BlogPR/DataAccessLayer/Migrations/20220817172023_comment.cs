using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_blogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_blogID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CommentID",
                table: "Blogs",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Comments_CommentID",
                table: "Blogs",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "commentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Comments_CommentID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CommentID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Blogs");

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
    }
}
