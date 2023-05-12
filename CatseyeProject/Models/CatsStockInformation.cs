using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsStockInformation:BaseClass
    {
      
      
        public int ProductdetailsId { get; set; }
        [Display(Name = "Product in Warehouse")]
        public int CurrentStock { get; set; }


        [Display(Name = "Total purchase")]
        
        public int ProductPurchase { get; set; }
        [Display(Name = "Total sell item")]
        public int SaleProduct { get; set; }
        public int TotalStock { get; set; }

        
        [ForeignKey("ProductdetailsId")]
        public virtual CatsProductdetails catsProductdetails { get; set; }

    }
}
