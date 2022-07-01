using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class ChangeTaxIntoServiceTaxInvoiceYearly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tax",
                table: "InvoiceYearly");

            migrationBuilder.AddColumn<double>(
                name: "Service_Tax",
                table: "InvoiceYearly",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service_Tax",
                table: "InvoiceYearly");

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "InvoiceYearly",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
