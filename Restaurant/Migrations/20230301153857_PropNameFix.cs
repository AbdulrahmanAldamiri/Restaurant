using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class PropNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMediaClass",
                table: "MasterSocialMedia",
                newName: "MasterSocialMediaClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MasterSocialMediaClass",
                table: "MasterSocialMedia",
                newName: "SocialMediaClass");
        }
    }
}
