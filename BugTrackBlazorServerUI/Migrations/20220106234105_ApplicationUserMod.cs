using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackBlazorServerUI.Migrations
{
    public partial class ApplicationUserMod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "displayName",
                table: "AspNetUsers",
                newName: "DisplayName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "AspNetUsers",
                newName: "displayName");
        }
    }
}
