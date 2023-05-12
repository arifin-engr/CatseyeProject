using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsCartDetails:BaseClass
    {
        public int Quantity { get; set; }
        public int productdetailsId { get; set; }
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual CatsCart catscart { get; set; }
        [ForeignKey("productdetailsId")]
        public virtual CatsProductdetails CatsProductdetails { get; set; }

    }
}
