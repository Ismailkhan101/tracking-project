using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class oneToManyRelationSalePersonAndCommission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "SalePersons");

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions",
                column: "SalePersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions");

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "SalePersons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_SalePersonId",
                table: "Comissions",
                column: "SalePersonId",
                unique: true,
                filter: "[SalePersonId] IS NOT NULL");
        }
    }
}
