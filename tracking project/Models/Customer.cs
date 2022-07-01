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

        
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        
        [EmailAddress]
        public string Email { get; set; }

        
        [Display(Name = "CNIC")]
        [Required(ErrorMessage = "CNIC Required!")]
        [RegularExpression(@"^\(?([0-9]{5})\)?[-. ]?([0-9]{7})[-. ]?([0-9]{1})$",
                   ErrorMessage = "Entered CNIC format is not valid.")]
        public string CNIC { get; set; }

       
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "OfficePhone")]
       
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered OfficePhone format is not valid.")]
        public string OfficePhone { get; set; }
        public string MotherName { get; set; }
        public string BloodGroup { get; set; }
       
        public  IList<CustomerVehicle> Vehicles { get; set; }

        public int? SalePersonID { get; set; }
        public virtual SalePerson SalePerson { get; set; }

    }
}
