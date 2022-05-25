using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitVehicles");

            migrationBuilder.DropColumn(
                name: "unitId",
                table: "CustomerVehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "unitId",
                table: "CustomerVehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UnitVehicles",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreshExpiry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeoFences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstallationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    SimNumber = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    UnitModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
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
    }
}
