using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class ChangeBankIntoPaymentMethodVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "CustomerVehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "CustomerVehicles");

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "CustomerVehicles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
