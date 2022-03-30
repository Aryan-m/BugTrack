using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackBlazorServerUI.Migrations
{
    public partial class ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgDataBase64",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgDataBytes",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "displayName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgDataBase64",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImgDataBytes",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "displayName",
                table: "AspNetUsers");
        }
    }
}
