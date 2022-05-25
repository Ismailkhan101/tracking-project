using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class customerIDAddedToCustomerVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SalePersons_SalePersonId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CustomerVehicles",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerVehicles_CustomerId",
                table: "CustomerVehicles",
                newName: "IX_CustomerVehicles_CustomerID");

            migrationBuilder.RenameColumn(
                name: "SalePersonId",
                table: "Customers",
                newName: "SalePersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SalePersonId",
                table: "Customers",
                newName: "IX_Customers_SalePersonID");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "CustomerVehicles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SalePersons_SalePersonID",
                table: "Customers",
                column: "SalePersonID",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerID",
                table: "CustomerVehicles",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SalePersons_SalePersonID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerID",
                table: "CustomerVehicles");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "CustomerVehicles",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerVehicles_CustomerID",
                table: "CustomerVehicles",
                newName: "IX_CustomerVehicles_CustomerId");

            migrationBuilder.RenameColumn(
                name: "SalePersonID",
                table: "Customers",
                newName: "SalePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SalePersonID",
                table: "Customers",
                newName: "IX_Customers_SalePersonId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerVehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SalePersons_SalePersonId",
                table: "Customers",
                column: "SalePersonId",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
