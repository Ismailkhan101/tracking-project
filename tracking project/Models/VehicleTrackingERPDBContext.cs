using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class VehicleTrackingERPDBContext:DbContext
    {
        public VehicleTrackingERPDBContext(DbContextOptions<VehicleTrackingERPDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalePerson> SalePersons { get; set; }
        public DbSet<CustomerVehicle> CustomerVehicles { get; set; }
        public DbSet<UnitVehicle> UnitVehicles { get; set; }

        public DbSet<InvoiceYearly> InvoiceYearly { get; set; }



    }
}
