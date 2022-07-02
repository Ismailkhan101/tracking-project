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


        /*public Double ExtraCharges { get; set; }*/

       // public string  Reason { get; set; }

        public string SpacialRemarkes { get; set; }

        //public string Bank { get; set; }
        /*public string PaymentMethod { get; set; }*/
        public string Source { get; set; }
       /* public Double UnitCost { get; set; }
        public Double ServiceTax { get; set; }*/
        
        //public double Commission { get; set; }
        /*public double Discount { get; set; }
        private double _Net;
        public double Net{
            get { return _Net;  }
            set { _Net = (UnitCost + ExtraCharges + _GST + DecidedAMF + Service) - Discount; } // - commission
        }*/

        
        /*public Double _GST;
         public double GST
         {
             get { return _GST; }
             set { _GST = UnitCost * (17 / 100); }
         }*/
        /*public double ReceiveAmount { get; set; }
        private double _Balance;
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = ( ReceiveAmount - _Net); }
        }*/
        public string PaymentRemarkes { get; set; }
        public bool PaymentAlert { get; set; }
        

       
        public string GeoFences { get; set; }
        public string Model { get; set; }
       
        
        [Display(Name = "Normal")]
        public string Normal { get; set; }

       
        [Display(Name = "Emergency")]
        public string Emergency { get; set; }
        public string Driver { get; set; }
        public string DrContact { get; set; }

        [Display(Name = " PName")]
        public string PName { get; set; }
        [Display(Name = " PRelation")]
        public string PRelation { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhonePOne")]
        
        
        public string PhonePOne { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhonePTwo")]
        
        public string PhonePTwo { get; set; }
        

        [Display(Name = " SName")]
        public string SName { get; set; }
        [Display(Name = " SRelation")]
        public string SRelation { get; set; }
        public string PhoneSOne { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneSTwo { get; set; }



        [Display(Name = " ECPName")]
        public string ECPName { get; set; }
        [Display(Name = " ECPRelation")]
        public string ECPRelation { get; set; }
        public string ECPPhoneOne { get; set; }
        public string ECPPhoneTwo { get; set; }
        public int CustomerID { get; set; }
        public string? unitId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual SalePerson SalePerson { get; set; }
        public virtual UnitVehicle UnitVehicle { get; set; }
        public virtual IList<Comission> Comissions { get; set; }

    }
}
