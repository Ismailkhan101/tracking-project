using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tracking_project.Models
{
    public class Model
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Display(Name = "Select your Make"), Required]
        public string Name { get; set; }
        [Display(Name = "Enter your Model"), Required]
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }



    }
}
