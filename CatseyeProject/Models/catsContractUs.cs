using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class catsContractUs : BaseClass
    {


        [ForeignKey("catsReason")]
        public int ReasonId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string InvoiceNumber { get; set; }
        public string Comment { get; set; }
        public virtual CatsReason catsReason { get; set; }
    }
}
