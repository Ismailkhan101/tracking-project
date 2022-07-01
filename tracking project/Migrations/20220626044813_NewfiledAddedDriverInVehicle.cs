using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class NewfiledAddedDriverInVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DrEmergencyContact",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Driver",
                table: "CustomerVehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrEmergencyContact",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Driver",
                table: "CustomerVehicles");
        }
    }
}
