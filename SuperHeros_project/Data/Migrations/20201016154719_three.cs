using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeros_project.Data.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "superHeroes");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "superHeroes");

            migrationBuilder.AddColumn<string>(
                name: "AlterEgo",
                table: "superHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CatchPhrase",
                table: "superHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "superHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryAbility",
                table: "superHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryAbility",
                table: "superHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgo",
                table: "superHeroes");

            migrationBuilder.DropColumn(
                name: "CatchPhrase",
                table: "superHeroes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "superHeroes");

            migrationBuilder.DropColumn(
                name: "PrimaryAbility",
                table: "superHeroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbility",
                table: "superHeroes");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "superHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "superHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
