using System.Collections.Generic;

namespace tracking_project.Models
{
    public class InvoiceDetails
    {

        public List <CustomerVehicle> customerVehicle { get; set; }   
        public double freshVehicleAmounts { get; set; } 

        public List <InvoiceYearly> InvoiceYearly { get; set; }       
        public double totalYearlyInvoice { get; set; }  

        public double totalAmounntDue { get; set; } 

    }
}
