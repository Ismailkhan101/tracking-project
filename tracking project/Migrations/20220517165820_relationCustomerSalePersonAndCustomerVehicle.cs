using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class relationCustomerSalePersonAndCustomerVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CNIC = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Office_Phone = table.Column<string>(nullable: false),
                    HomePhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "SalePersons",
                columns: table => new
                {
                    SalePersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CNIC = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePersons", x => x.SalePersonId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerVehicles",
                columns: table => new
                {
                    VehicalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNo = table.Column<string>(nullable: false),
                    MakeModel = table.Column<string>(nullable: false),
                    EngineNo = table.Column<string>(nullable: false),
                    ChasisNo = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    ExtraFeatures = table.Column<string>(nullable: true),
                    ExtraCharges = table.Column<double>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    SpacialRemarkes = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    InvoiceAmount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    TaxDeduction = table.Column<double>(nullable: false),
                    Commission = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Net = table.Column<double>(nullable: false),
                    ReceiveAmount = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    PaymentRemarkes = table.Column<string>(nullable: true),
                    PaymentAlert = table.Column<bool>(nullable: false),
                    DueDate = table.Column<string>(nullable: true),
                    Deduction = table.Column<double>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    SalePersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerVehicles", x => x.VehicalId);
                    table.ForeignKey(
                        name: "FK_CustomerVehicles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerVehicles_SalePersons_SalePersonId",
                        column: x => x.SalePersonId,
                        principalTable: "SalePersons",
                        principalColumn: "SalePersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerVehicles_CustomerId",
                table: "CustomerVehicles",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerVehicles_SalePersonId",
                table: "CustomerVehicles",
                column: "SalePersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerVehicles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SalePersons");
        }
    }
}
