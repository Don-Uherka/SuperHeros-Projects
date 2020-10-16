using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeros_project.Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "superHeroes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_superHeroes",
                table: "superHeroes",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_superHeroes",
                table: "superHeroes");

            migrationBuilder.RenameTable(
                name: "superHeroes",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "id");
        }
    }
}
