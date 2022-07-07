using System.Collections.Generic;
using System.Linq;

namespace tracking_project.Models
{
    public class InvoiceDetails
    {

        public IOrderedEnumerable<FreshPayment> freshPayments { get; set; }   
        public double freshVehicleAmounts { get; set; } 

        public IOrderedEnumerable<InvoiceYearly> InvoiceYearly { get; set; }       
        public double totalYearlyInvoice { get; set; }  

        public double totalAmounntDue { get; set; } 

    }
}
