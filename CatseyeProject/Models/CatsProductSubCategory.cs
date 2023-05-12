using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsProductSubCategory : BaseClass
    {
        public int CategoryId { get; set; }
        public string SubName { get; set; }
        public virtual ICollection<CatsproductType> catsproductType { get; set; }
        [ForeignKey("CategoryId")]
        public virtual CatsProductCategory catsProductCategories { get; set; }
    }
}
