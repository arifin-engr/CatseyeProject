using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsReason : BaseClass
    {
  
        public string Reason { get; set; }

        public virtual IList<catsContractUs> CatsContractUs { get; set; }
    }
}
