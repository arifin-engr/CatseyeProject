using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsOrder : BaseClass
    {
   
        public int CustomerId { get; set; }
       
        public int ShippingId { get; set; }
        public int BillingId { get; set; }
        public float shipCharage { get; set; }
        public string ShippingLabel { get; set; }
        public string InvoiceNo { get; set; }
        public float TotalAmount { get; set; }
        public string PaymentToken { get; set; }
        public float ReturnAmount { get; set; }

        public bool IsDelivered { get; set; } = false;      
        public bool  Islabelprint { get; set; }=false;
       
       
        [ForeignKey("CustomerId")]
        public virtual CatsCustomer CatsCustomer { get; set; }
       
        [ForeignKey("ShippingId")]
        public virtual CatsShippingadres Shippingadres { get; set; }
        [ForeignKey("BillingId")]
        public virtual CatsBillingadres CatsBillingadres { get; set; }
        public virtual List<CatsOrderDetails> CatsOrderDetails { get; set; }
    }
}
