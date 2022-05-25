using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class SalePersonTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "SalePersons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalePersonId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SalePersonId",
                table: "Customers",
                column: "SalePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SalePersons_SalePersonId",
                table: "Customers",
                column: "SalePersonId",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SalePersons_SalePersonId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SalePersonId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SalePersons");

            migrationBuilder.DropColumn(
                name: "SalePersonId",
                table: "Customers");
        }
    }
}
