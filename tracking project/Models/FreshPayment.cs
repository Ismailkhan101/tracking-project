using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class FreshPayment
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public double UnitCost { get; set; }
        public double ServiceTax { get; set; }
        public double Net { get; set; }
        public int SalePersonID { get; set; }
        
        public DateTime DueDate { get; set; }
        public double ReceiveAmount { get; set; }
       
        public double Discount { get; set; }
        public double Commission { get; set; }
        public double ExtraCharges { get; set; }
        private double _Balance;
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = (ReceiveAmount - Net); }
        }
        public virtual SalePerson SalePerson { get; set; }

        public int VehicleID { get; set; }
        public virtual CustomerVehicle Vehicle { get; set; }

        public string PaymentMethod { get; set; }
       
        public Double TaxDeduction { get; set; }
        public double DecidedAMF { get; set; }
        public double Deduction { get; set; }
        public double Invoice;
        public double _GST;
        public bool GSTCheck;
        public double Service;
    }
}
