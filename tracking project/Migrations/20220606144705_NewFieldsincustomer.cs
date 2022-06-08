using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class NewFieldsincustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commission",
                table: "InvoiceYearly");

            migrationBuilder.DropColumn(
                name: "HomePhone",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Office_Phone",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "InvoiceYearly",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Emergency",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Normal",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhonePOne",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhonePTwo",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneSOne",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneSTwo",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SName",
                table: "Customers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "InvoiceYearly");

            migrationBuilder.DropColumn(
                name: "Emergency",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Normal",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhonePOne",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhonePTwo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneSOne",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneSTwo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SName",
                table: "Customers");

            migrationBuilder.AddColumn<double>(
                name: "Commission",
                table: "InvoiceYearly",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "HomePhone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Office_Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
