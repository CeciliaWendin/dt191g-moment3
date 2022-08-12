using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Collection.Migrations
{
    public partial class MoreChengesToGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Albums",
                newName: "GenreList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreList",
                table: "Albums",
                newName: "Genre");
        }
    }
}
