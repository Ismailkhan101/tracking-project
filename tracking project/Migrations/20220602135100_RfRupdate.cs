using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class RfRupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Request",
                table: "RFRs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransferVehicleId",
                table: "RFRs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "RFRs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Request",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "TransferVehicleId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "RFRs");
        }
    }
}
