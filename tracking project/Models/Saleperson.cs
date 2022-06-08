using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class SalePerson
    {
       
        
        public int SalePersonId { get; set; }
        [Required(ErrorMessage = "Please Enter  Name ...")]
        [Display(Name = " Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "CNIC")]
        [Required(ErrorMessage = "CNIC Required!")]
        [RegularExpression(@"^\(?([0-9]{5})\)?[-. ]?([0-9]{7})[-. ]?([0-9]{1})$",
                   ErrorMessage = "Entered CNIC format is not valid.")]
        public string CNIC { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
       
        
        public int? CustomerId { get; set; }
        public virtual IList<Customer> Customers { get; set; }
       // public virtual IList<Comission> Comissions { get; set; }

    }
}
