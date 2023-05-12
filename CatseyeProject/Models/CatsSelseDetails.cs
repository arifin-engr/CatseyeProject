using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsSelseDetails:BaseClass
    {
     
        public double SalesAmount { get; set; }
  
        public int ProductId { get; set; }       
        [ForeignKey("ProductId")]
        public virtual CatsProduct catsProduct { get; set; }
    }
}
