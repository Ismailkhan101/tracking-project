using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class commissionIdremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comissions_CustomerVehicles_CommisionId",
                table: "Comissions");

            

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Comissions_CustomerVehicles_VehicleId",
                table: "Comissions",
                column: "VehicleId",
                principalTable: "CustomerVehicles",
                principalColumn: "VehicalId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comissions_CustomerVehicles_VehicleId",
                table: "Comissions");

            migrationBuilder.DropIndex(
                name: "IX_Comissions_VehicleId",
                table: "Comissions");


            migrationBuilder.AddForeignKey(
                name: "FK_Comissions_CustomerVehicles_CommisionId",
                table: "Comissions",
                column: "CommisionId",
                principalTable: "CustomerVehicles",
                principalColumn: "VehicalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
