using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class BillingViewModel
    {

        public List<Customer> Customer { get; set; }
        public List<CustomerVehicle> CustomerVehicles { get; set; }

    }
}
