using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsProductdetails : BaseClass
    {
      
        [ForeignKey("catsProduct")]
        public int ProductId { get; set; }
        [ForeignKey("CatsProductSize")]
        public int sizeId { get; set; }
       
        public string Color { get; set; }
        public float price { get; set; }
        public float Newprice { get; set; }

        public float Cost { get; set; }
        [Required]
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public float vat { get; set; }

        public string Image { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string barcodeImage { get; set; }       
        public virtual CatsProduct catsProduct { get; set; }
      
        public virtual CatsProductSize CatsProductSize { get; set; }
        public virtual ICollection<CatsCart> Carts { get; set; }
        public virtual ICollection<CatsSelseDetails> CatsSelseDetails { get; set; }
        public virtual ICollection<CatsStockInformation> CatsStockInformation { get; set; }

    }
}
