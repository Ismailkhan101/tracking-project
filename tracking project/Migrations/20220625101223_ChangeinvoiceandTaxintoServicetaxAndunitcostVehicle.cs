using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class ChangeinvoiceandTaxintoServicetaxAndunitcostVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceAmount",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<double>(
                name: "ServiceTax",
                table: "CustomerVehicles",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UnitCost",
                table: "CustomerVehicles",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceTax",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "UnitCost",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<double>(
                name: "InvoiceAmount",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
