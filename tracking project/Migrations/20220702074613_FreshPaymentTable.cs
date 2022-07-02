using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class FreshPaymentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "DecidedAMF",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Deduction",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ExtraCharges",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "Net",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ReceiveAmount",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ServiceTax",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "TaxDeduction",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "UnitCost",
                table: "CustomerVehicles");

            migrationBuilder.CreateTable(
                name: "freshPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitCost = table.Column<double>(nullable: false),
                    ServiceTax = table.Column<double>(nullable: false),
                    Net = table.Column<double>(nullable: false),
                    SalePersonID = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    ReceiveAmount = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Commission = table.Column<double>(nullable: false),
                    ExtraCharges = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    VehicleID = table.Column<int>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true),
                    MyProperty = table.Column<double>(nullable: false),
                    TaxDeduction = table.Column<double>(nullable: false),
                    DecidedAMF = table.Column<double>(nullable: false),
                    Deduction = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_freshPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_freshPayments_SalePersons_SalePersonID",
                        column: x => x.SalePersonID,
                        principalTable: "SalePersons",
                        principalColumn: "SalePersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_freshPayments_CustomerVehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "CustomerVehicles",
                        principalColumn: "VehicalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_freshPayments_SalePersonID",
                table: "freshPayments",
                column: "SalePersonID");

            migrationBuilder.CreateIndex(
                name: "IX_freshPayments_VehicleID",
                table: "freshPayments",
                column: "VehicleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "freshPayments");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DecidedAMF",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Deduction",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "CustomerVehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ExtraCharges",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Net",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "CustomerVehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ReceiveAmount",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ServiceTax",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TaxDeduction",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UnitCost",
                table: "CustomerVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
