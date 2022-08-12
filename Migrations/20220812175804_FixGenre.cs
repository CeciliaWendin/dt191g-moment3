using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Collection.Migrations
{
    public partial class FixGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "GenreList",
                table: "Albums",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreList",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Albums",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
