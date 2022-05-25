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
    [Migration("20220521122541_customerIDAddedToCustomerVehicle")]
    partial class customerIDAddedToCustomerVehicle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tracking_project.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
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

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChasisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<double>("Deduction")
                        .HasColumnType("float");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExtraCharges")
                        .HasColumnType("float");

                    b.Property<string>("ExtraFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InvoiceAmount")
                        .HasColumnType("float");

                    b.Property<string>("MakeModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Net")
                        .HasColumnType("float");

                    b.Property<bool>("PaymentAlert")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentRemarkes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ReceiveAmount")
                        .HasColumnType("float");

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalePersonId")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpacialRemarkes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("TaxDeduction")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VehicalId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SalePersonId");

                    b.ToTable("CustomerVehicles");
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
#pragma warning restore 612, 618
        }
    }
}
