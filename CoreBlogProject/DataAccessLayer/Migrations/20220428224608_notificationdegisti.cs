using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class notificationdegisti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationSymbol",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "NotificationType",
                table: "Notifications",
                newName: "NotificationTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationTitle",
                table: "Notifications",
                newName: "NotificationType");

            migrationBuilder.AddColumn<string>(
                name: "NotificationSymbol",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
