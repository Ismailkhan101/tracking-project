using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class TransferSecondryUserToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrEmergencyContact",
                table: "CustomerVehicles");

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
                name: "PName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PRelation",
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

            migrationBuilder.DropColumn(
                name: "SRelation",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Normal",
                table: "CustomerVehicles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Emergency",
                table: "CustomerVehicles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DrContact",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPName",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneOne",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneTwo",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPRelation",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRelation",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhonePOne",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhonePTwo",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneSOne",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneSTwo",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SName",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SRelation",
                table: "CustomerVehicles",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficePhone",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrContact",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ECPName",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ECPPhoneOne",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ECPPhoneTwo",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "ECPRelation",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PName",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PRelation",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PhonePOne",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PhonePTwo",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PhoneSOne",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "PhoneSTwo",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "SName",
                table: "CustomerVehicles");

            migrationBuilder.DropColumn(
                name: "SRelation",
                table: "CustomerVehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Normal",
                table: "CustomerVehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Emergency",
                table: "CustomerVehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrEmergencyContact",
                table: "CustomerVehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficePhone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneOne",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ECPPhoneTwo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ECPRelation",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRelation",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhonePOne",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhonePTwo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneSOne",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneSTwo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SRelation",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
