﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace tracking_project.Migrations
{
    public partial class netintoInvoiceYearly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Net",
                table: "InvoiceYearly",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Net",
                table: "InvoiceYearly");
        }
    }
}
