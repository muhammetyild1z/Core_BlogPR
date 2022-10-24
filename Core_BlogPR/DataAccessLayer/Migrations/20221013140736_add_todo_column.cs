using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_todo_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TodoID",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    TodoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TodoContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TodoStatüs = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.TodoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Writers_TodoID",
                table: "Writers",
                column: "TodoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Todo_TodoID",
                table: "Writers",
                column: "TodoID",
                principalTable: "Todo",
                principalColumn: "TodoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Todo_TodoID",
                table: "Writers");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Writers_TodoID",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "TodoID",
                table: "Writers");
        }
    }
}
