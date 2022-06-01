using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace tracking_project.Models
{
    public class CustomerVehicle
    {
      [System.ComponentModel.DataAnnotations.Key]
        public int VehicalId { get; set; }
        [Required]
        public string RegistrationNo { get; set; }
        
        [Required]
        public  string MakeModel{ get; set; }
        
        [Required]
        public string EngineNo{ get; set; }

        [Required]
        public string ChasisNo { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        public string ExtraFeatures { get; set; }


        public Double ExtraCharges { get; set; }

        public string  Reason { get; set; }

        public string SpacialRemarkes { get; set; }

        public string Bank { get; set; }

        public string Source { get; set; }
        public Double InvoiceAmount { get; set; }
        public Double Tax { get; set; }
        public Double TaxDeduction { get; set; }
        public double Commission { get; set; }
        public double Discount { get; set; }
        private double _Net;
        public double Net{
            get { return _Net;  }
            set { _Net = (Tax + InvoiceAmount + ExtraCharges) - Discount; }
        }


        public double ReceiveAmount { get; set; }
        private double _Balance;
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = ( ReceiveAmount - _Net); }
        }
        public string PaymentRemarkes { get; set; }
        public bool PaymentAlert { get; set; }
        public string DueDate { get; set; }

        public double DecidedAMF { get; set; }
        public double Deduction { get; set; }
        
        public int CustomerID { get; set; }
        public string? unitId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual SalePerson SalePerson { get; set; }
        public virtual UnitVehicle UnitVehicle { get; set; }

    }
}
