using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class AddNewInformationIntoCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneOne",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneTwo",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ECPRelation",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhone",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRelation",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SRelation",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ECPName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ECPPhoneOne",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ECPPhoneTwo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ECPRelation",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OfficePhone",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PRelation",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SRelation",
                table: "Customers");
        }
    }
}
