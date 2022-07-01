using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class ChangePasswordEmrgenceToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emergency",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Normal",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Emergency",
                table: "CustomerVehicles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Normal",
                table: "CustomerVehicles",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emergency",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Normal",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<string>(
                name: "Emergency",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Normal",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
