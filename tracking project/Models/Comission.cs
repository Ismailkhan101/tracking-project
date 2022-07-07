using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class Comission
    {
        
       [System.ComponentModel.DataAnnotations.Key]
        public int CommisionId { get; set; }
        [Required]
        public double Commission { get; set; }
        [Required]
        public string  CommissionType { get; set; }

        public int? VehicleId { get; set; }
        public int? SalePersonId { get; set; }
        public CustomerVehicle Vehicle { get; set; }
        //public SalePerson SalePersons { get; set; }


    }
}
