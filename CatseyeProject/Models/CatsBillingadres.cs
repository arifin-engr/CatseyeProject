using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsBillingadres:BaseClass
    {
     
        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        public string Address { get; set; }
        public string Address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public virtual CatsCustomer customer { get; set; }       
      
    }
}
