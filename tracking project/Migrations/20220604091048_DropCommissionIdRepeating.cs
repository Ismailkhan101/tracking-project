using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class DropCommissionIdRepeating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RFRs_Comissions_CommisionId",
                table: "RFRs");

            migrationBuilder.DropIndex(
                name: "IX_RFRs_CommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommissionId",
                table: "RFRs");

            migrationBuilder.AddColumn<int>(
                name: "CommissionCommisionId",
                table: "RFRs",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RFRs_Comissions_CommissionCommisionId",
                table: "RFRs");

            migrationBuilder.DropIndex(
                name: "IX_RFRs_CommissionCommisionId",
                table: "RFRs");

            migrationBuilder.DropColumn(
                name: "CommissionCommisionId",
                table: "RFRs");

            migrationBuilder.AddColumn<int>(
                name: "CommisionId",
                table: "RFRs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommissionId",
                table: "RFRs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RFRs_CommisionId",
                table: "RFRs",
                column: "CommisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RFRs_Comissions_CommisionId",
                table: "RFRs",
                column: "CommisionId",
                principalTable: "Comissions",
                principalColumn: "CommisionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
