using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class RFR
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Required]
        public double Charges { get; set; }
       
        
        public double ReceiveAmount { get; set; }
        public double Balance { get; set; }
        public string  Agent { get; set; }  
        public string Request { get; set; }
        public int VehicleId { get; set; }
        public int TransferVehicleId { get; set; }

        /*public int? CommisionId { get; set; }*/
      // public virtual Comission Commission { get; set; }

    }
}
