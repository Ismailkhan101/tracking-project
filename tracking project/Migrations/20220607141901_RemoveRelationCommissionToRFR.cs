using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class RemoveRelationCommissionToRFR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RFRs_Comissions_CommissionCommisionId",
                table: "RFRs");

            migrationBuilder.DropIndex(
                name: "IX_RFRs_CommissionCommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommissionCommisionId",
                table: "RFRs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "RFRs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommissionCommisionId",
                table: "RFRs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RFRs_CommissionCommisionId",
                table: "RFRs",
                column: "CommissionCommisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RFRs_Comissions_CommissionCommisionId",
                table: "RFRs",
                column: "CommissionCommisionId",
                principalTable: "Comissions",
                principalColumn: "CommisionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
