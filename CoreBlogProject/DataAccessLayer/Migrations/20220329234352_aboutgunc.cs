using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class aboutgunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutDetails1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutDetails2",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "AboutMapLocation",
                table: "Abouts",
                newName: "AboutTitle");

            migrationBuilder.RenameColumn(
                name: "AboutImage2",
                table: "Abouts",
                newName: "AboutImage");

            migrationBuilder.RenameColumn(
                name: "AboutImage1",
                table: "Abouts",
                newName: "AboutDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutTitle",
                table: "Abouts",
                newName: "AboutMapLocation");

            migrationBuilder.RenameColumn(
                name: "AboutImage",
                table: "Abouts",
                newName: "AboutImage2");

            migrationBuilder.RenameColumn(
                name: "AboutDetails",
                table: "Abouts",
                newName: "AboutImage1");

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
