using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsproductType : BaseClass
    {
        public int SubcategoryId { get; set; }
        [Display(Name ="Product Type")]
        [Required]
        public string Type { get; set; }
        [Display(Name = "Cover Image")]

        public string Image { get; set; }
        public virtual CatsProductSubCategory catsProductSubCategories { get; set; }

    }
}
