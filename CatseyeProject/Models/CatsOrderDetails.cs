using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsOrderDetails : BaseClass
    {
      
      
        public int OrderId { get; set; }
        public int? ReasonId { get; set; }
        [ForeignKey("CatsProductdetails")]
        public int ProductdetailsId { get; set; }
        public int Quantity { get; set; }
        public int ReturnQuantity { get; set; }
        public bool IsReturned { get; set; } = false;
        public float DamageFee { get; set; }
        public DateTime ReturnSubmitDate { get; set; }
        public float Subtotal { get; set; }
        [ForeignKey("ReasonId")]
        public virtual CatsReturnReason CatsReturnReason { get; set; }
        [ForeignKey("OrderId")]
        public virtual CatsOrder catsOrder { get; set; }
        public virtual CatsProductdetails CatsProductdetails { get; set; }
       

    }
}
