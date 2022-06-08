using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class changeVehicleAndCommissionRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "CustomerVehicles");

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions");

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "CustomerVehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");
        }
    }
}
