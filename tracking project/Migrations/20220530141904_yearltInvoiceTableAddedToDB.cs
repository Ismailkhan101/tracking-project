using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class yearltInvoiceTableAddedToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceYearly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidFromDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    AmfStatus = table.Column<bool>(nullable: false),
                    YearlyPaymentStatus = table.Column<bool>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false),
                    Comission = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    ReceivedAmount = table.Column<double>(nullable: false),
                    BalanceAmount = table.Column<double>(nullable: false),
                    TaxDeduction = table.Column<double>(nullable: false),
                    Commission = table.Column<double>(nullable: false),
                    VehicalId = table.Column<int>(nullable: true),
                    CustomerVehicleVehicalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceYearly", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceYearly_CustomerVehicles_CustomerVehicleVehicalId",
                        column: x => x.CustomerVehicleVehicalId,
                        principalTable: "CustomerVehicles",
                        principalColumn: "VehicalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceYearly_CustomerVehicleVehicalId",
                table: "InvoiceYearly",
                column: "CustomerVehicleVehicalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceYearly");
        }
    }
}
