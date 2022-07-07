using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class removeextramembersfromFresspayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "Deduction",
                table: "freshPayments");

            migrationBuilder.DropColumn(
                name: "TaxDeduction",
                table: "freshPayments");

            migrationBuilder.AddColumn<string>(
                name: "MakeName",
                table: "Makes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Company",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommissionType",
                table: "Comissions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MakeName",
                table: "Makes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Deduction",
                table: "freshPayments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TaxDeduction",
                table: "freshPayments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CommissionType",
                table: "Comissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
