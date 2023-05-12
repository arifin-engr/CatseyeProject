using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsproductDescription : BaseClass
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        [ForeignKey("ProductId")]
        public virtual CatsProduct CatsProduct { get; set; }
    }
}
