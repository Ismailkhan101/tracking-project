using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class UnitVehicle
    {
        [Key]
        public int UnitId { get; set; }

        [Required]
        public string UnitModel { get; set; }

        [Required]
        public int SimNumber { get; set; }

        public int PostalCode { get; set; }

        public string GeoFences { get; set; }



        public String? InstallationDate { get; set; }

        public bool? Status { get; set; }

        public string FreshExpiry { get; set; }

        public int? VehicleId { get; set; }
        public CustomerVehicle Vehicle { get; set; }

    }
}
