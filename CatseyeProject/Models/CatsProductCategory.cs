using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsProductCategory:BaseClass
    {
     
        [Display(Name ="Category Name")]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<CatsProductSubCategory> CatsProductSubCategories { get; set; }


    }
}
