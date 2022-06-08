using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class RelationSalePersonVehicleandCommision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RFRCommision",
                table: "RFRs");

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "SalePersons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "RFRs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommissionId",
                table: "RFRs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comissions",
                columns: table => new
                {
                    CommisionId = table.Column<int>(nullable: false),
                    Commission = table.Column<double>(nullable: false),
                    CommissionType = table.Column<string>(nullable: true),
                    VehicleId = table.Column<int>(nullable: true),
                    SalePersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissions", x => x.CommisionId);
                    table.ForeignKey(
                        name: "FK_Comissions_CustomerVehicles_CommisionId",
                        column: x => x.CommisionId,
                        principalTable: "CustomerVehicles",
                        principalColumn: "VehicalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comissions_SalePersons_SalePersonId",
                        column: x => x.SalePersonId,
                        principalTable: "SalePersons",
                        principalColumn: "SalePersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RFRs_CommisionId",
                table: "RFRs",
                column: "CommisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions",
                column: "SalePersonId",
                unique: true,
                filter: "[SalePersonId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_RFRs_Comissions_CommisionId",
                table: "RFRs",
                column: "CommisionId",
                principalTable: "Comissions",
                principalColumn: "CommisionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RFRs_Comissions_CommisionId",
                table: "RFRs");

            migrationBuilder.DropTable(
                name: "Comissions");

            migrationBuilder.DropIndex(
                name: "IX_RFRs_CommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "SalePersons");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommissionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<double>(
                name: "RFRCommision",
                table: "RFRs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
