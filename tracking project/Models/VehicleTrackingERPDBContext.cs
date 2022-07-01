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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CustomerVehicle>()
            //.HasOne(a => a.Comission)
            //.WithOne(a => a.Vehicle)
            //.HasForeignKey<Comission>(c => c.CommisionId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalePerson> SalePersons { get; set; }
        public DbSet<CustomerVehicle> CustomerVehicles { get; set; }
        public DbSet<UnitVehicle> UnitVehicles { get; set; }

        public DbSet<InvoiceYearly> InvoiceYearly { get; set; }

        public DbSet<RFR> RFRs { get; set; }

        public DbSet<Comission> Comissions { get; set; }
       public DbSet<Company> Company{ get; set; }
       public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
       // public DbSet<FreshPayment> freshPayments{ get; set; }
        public DbSet<Technician> Technicians { get; set; }
        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
