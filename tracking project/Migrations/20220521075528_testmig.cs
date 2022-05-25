using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class testmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_SalePersons_salePersonId",
                table: "CustomerVehicles");

            migrationBuilder.RenameColumn(
                name: "salePersonId",
                table: "CustomerVehicles",
                newName: "SalePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerVehicles_salePersonId",
                table: "CustomerVehicles",
                newName: "IX_CustomerVehicles_SalePersonId");

            migrationBuilder.AlterColumn<int>(
                name: "SalePersonId",
                table: "CustomerVehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerVehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_SalePersons_SalePersonId",
                table: "CustomerVehicles",
                column: "SalePersonId",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerVehicles_SalePersons_SalePersonId",
                table: "CustomerVehicles");

            migrationBuilder.RenameColumn(
                name: "SalePersonId",
                table: "CustomerVehicles",
                newName: "salePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerVehicles_SalePersonId",
                table: "CustomerVehicles",
                newName: "IX_CustomerVehicles_salePersonId");

            migrationBuilder.AlterColumn<int>(
                name: "salePersonId",
                table: "CustomerVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerVehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_Customers_CustomerId",
                table: "CustomerVehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerVehicles_SalePersons_salePersonId",
                table: "CustomerVehicles",
                column: "salePersonId",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
