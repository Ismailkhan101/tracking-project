using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class InvoiceYearly
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Required]
        public DateTime ValidFromDate { get; set; }

        [Required]
        public DateTime ExpiryDate{ get; set; }

        [Required]
        public bool AmfStatus { get; set; }

        [Required]
        public bool YearlyPaymentStatus { get; set; }

        

        [Required]
        public DateTime Year { get; set; }



        public Double Comission { get; set; }

        public Double Discount { get; set; }

        public Double Service_Tax { get; set; }

        
        public Double ReceivedAmount { get; set; }
        public Double BalanceAmount { get; set; }
        public Double TaxDeduction { get; set; }

        public string Remarks { get; set; }
        public double AMF { get; set; }

        public double Net { get; set; }
        public int? VehicalId { get; set; }
        public virtual CustomerVehicle CustomerVehicle { get; set; }

    }
}
