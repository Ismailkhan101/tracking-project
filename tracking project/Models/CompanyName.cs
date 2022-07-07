using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class Company
    {
        
       [System.ComponentModel.DataAnnotations.Key]
        public int CompanyId { get; set; }
       [Required]
        public string CompanyName{ get; set; }
        


    }
}
