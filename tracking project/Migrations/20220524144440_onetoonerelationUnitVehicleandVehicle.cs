using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class onetoonerelationUnitVehicleandVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "unitId",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UnitVehicles",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitModel = table.Column<string>(nullable: false),
                    SimNumber = table.Column<int>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    GeoFences = table.Column<string>(nullable: true),
                    InstallationDate = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    FreshExpiry = table.Column<string>(nullable: true),
                    VehicleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitVehicles", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_UnitVehicles_CustomerVehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "CustomerVehicles",
                        principalColumn: "VehicalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitVehicles_VehicleId",
                table: "UnitVehicles",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitVehicles");

            migrationBuilder.DropColumn(
                name: "unitId",
                table: "CustomerVehicles");
        }
    }
}
