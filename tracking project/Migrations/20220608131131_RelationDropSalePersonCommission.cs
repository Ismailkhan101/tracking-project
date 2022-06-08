using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class RelationDropSalePersonCommission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comissions_SalePersons_SalePersonId",
                table: "Comissions");

            migrationBuilder.DropIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions",
                column: "SalePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comissions_SalePersons_SalePersonId",
                table: "Comissions",
                column: "SalePersonId",
                principalTable: "SalePersons",
                principalColumn: "SalePersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
