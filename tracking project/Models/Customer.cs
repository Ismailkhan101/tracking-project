using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class Customer
    {
        
        public  int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter  Name ...")]
        [Display(Name = " Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Company_Name...")]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        
        [Display(Name = "CNIC")]
        [Required(ErrorMessage = "CNIC Required!")]
        [RegularExpression(@"^\(?([0-9]{5})\)?[-. ]?([0-9]{7})[-. ]?([0-9]{1})$",
                   ErrorMessage = "Entered CNIC format is not valid.")]
        public string CNIC { get; set; }

        [Required(ErrorMessage = "Please Enter Date...")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Office_Phone")]
        [Required(ErrorMessage = "Office_Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered Office_Phone format is not valid.")]
        public string Office_Phone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "HomePhone")]
        [Required(ErrorMessage = "Home_Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered Home_Phone format is not valid.")]
        public string HomePhone { get; set; }

        public  IList<CustomerVehicle> Vehicles { get; set; }

        public int? SalePersonID { get; set; }
        public virtual SalePerson SalePerson { get; set; }

    }
}
