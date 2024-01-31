using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class PhoneNumberAndEmailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SystemSettingEmail",
                table: "SystemSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemSettingPhoneNumber",
                table: "SystemSetting",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemSettingEmail",
                table: "SystemSetting");

            migrationBuilder.DropColumn(
                name: "SystemSettingPhoneNumber",
                table: "SystemSetting");
        }
    }
}
