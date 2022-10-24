using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_writer_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "writerID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_writerID",
                table: "Blogs",
                column: "writerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_writerID",
                table: "Blogs",
                column: "writerID",
                principalTable: "Writers",
                principalColumn: "writerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_writerID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_writerID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "writerID",
                table: "Blogs");
        }
    }
}
