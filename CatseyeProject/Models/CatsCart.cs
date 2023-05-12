using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsCart:BaseClass
    {
        public int CustomerId { get; set; }
        public bool isProcess { get; set; } = false;
        public bool Isinvoice { get; set; } = false;
        [ForeignKey("CustomerId")]
        public virtual CatsCustomer CatsCustomer { get; set; }
        public virtual List<CatsCartDetails> CartDetails { get; set; }
    }
}
