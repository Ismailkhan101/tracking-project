﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tracking_project.Models;

namespace tracking_project.Migrations
{
    [DbContext(typeof(VehicleTrackingERPDBContext))]
    [Migration("20220630140714_TechniciansModel")]
    partial class TechniciansModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tracking_project.Models.Comission", b =>
                {
                    b.Property<int>("CommisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<string>("CommissionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalePersonId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("CommisionId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Comissions");
                });

            modelBuilder.Entity("tracking_project.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("tracking_project.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECPName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECPPhoneOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECPPhoneTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECPRelation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRelation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhonePOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhonePTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SRelation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalePersonID")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("SalePersonID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("tracking_project.Models.CustomerVehicle", b =>
                {
                    b.Property<int>("VehicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("ChasisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<double>("DecidedAMF")
                        .HasColumnType("float");

                    b.Property<double>("Deduction")
                        .HasColumnType("float");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("DrEmergencyContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emergency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExtraCharges")
                        .HasColumnType("float");

                    b.Property<string>("ExtraFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeoFences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakeModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Net")
                        .HasColumnType("float");

                    b.Property<string>("Normal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentAlert")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentRemarkes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ReceiveAmount")
                        .HasColumnType("float");

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalePersonId")
                        .HasColumnType("int");

                    b.Property<double>("ServiceTax")
                        .HasColumnType("float");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpacialRemarkes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxDeduction")
                        .HasColumnType("float");

                    b.Property<double>("UnitCost")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<string>("unitId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicalId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SalePersonId");

                    b.ToTable("CustomerVehicles");
                });

            modelBuilder.Entity("tracking_project.Models.InvoiceYearly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AMF")
                        .HasColumnType("float");

                    b.Property<bool>("AmfStatus")
                        .HasColumnType("bit");

                    b.Property<double>("BalanceAmount")
                        .HasColumnType("float");

                    b.Property<double>("Comission")
                        .HasColumnType("float");

                    b.Property<int?>("CustomerVehicleVehicalId")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ReceivedAmount")
                        .HasColumnType("float");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Service_Tax")
                        .HasColumnType("float");

                    b.Property<double>("TaxDeduction")
                        .HasColumnType("float");

                    b.Property<DateTime>("ValidFromDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VehicalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.Property<bool>("YearlyPaymentStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerVehicleVehicalId");

                    b.ToTable("InvoiceYearly");
                });

            modelBuilder.Entity("tracking_project.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("tracking_project.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("tracking_project.Models.RFR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<double>("Charges")
                        .HasColumnType("float");

                    b.Property<double>("ReceiveAmount")
                        .HasColumnType("float");

                    b.Property<string>("Request")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransferVehicleId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RFRs");
                });

            modelBuilder.Entity("tracking_project.Models.SalePerson", b =>
                {
                    b.Property<int>("SalePersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalePersonId");

                    b.ToTable("SalePersons");
                });

            modelBuilder.Entity("tracking_project.Models.Technician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Technicians");
                });

            modelBuilder.Entity("tracking_project.Models.UnitVehicle", b =>
                {
                    b.Property<string>("UnitId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("InstallationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("SimNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UnitModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("UnitId");

                    b.HasIndex("VehicleId")
                        .IsUnique()
                        .HasFilter("[VehicleId] IS NOT NULL");

                    b.ToTable("UnitVehicles");
                });

            modelBuilder.Entity("tracking_project.Models.Comission", b =>
                {
                    b.HasOne("tracking_project.Models.CustomerVehicle", "Vehicle")
                        .WithMany("Comissions")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("tracking_project.Models.Customer", b =>
                {
                    b.HasOne("tracking_project.Models.SalePerson", "SalePerson")
                        .WithMany("Customers")
                        .HasForeignKey("SalePersonID");
                });

            modelBuilder.Entity("tracking_project.Models.CustomerVehicle", b =>
                {
                    b.HasOne("tracking_project.Models.Customer", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tracking_project.Models.SalePerson", "SalePerson")
                        .WithMany()
                        .HasForeignKey("SalePersonId");
                });

            modelBuilder.Entity("tracking_project.Models.InvoiceYearly", b =>
                {
                    b.HasOne("tracking_project.Models.CustomerVehicle", "CustomerVehicle")
                        .WithMany()
                        .HasForeignKey("CustomerVehicleVehicalId");
                });

            modelBuilder.Entity("tracking_project.Models.Model", b =>
                {
                    b.HasOne("tracking_project.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tracking_project.Models.UnitVehicle", b =>
                {
                    b.HasOne("tracking_project.Models.CustomerVehicle", "Vehicle")
                        .WithOne("UnitVehicle")
                        .HasForeignKey("tracking_project.Models.UnitVehicle", "VehicleId");
                });
#pragma warning restore 612, 618
        }
    }
}
