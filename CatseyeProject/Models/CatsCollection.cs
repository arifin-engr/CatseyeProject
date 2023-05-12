using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsCollection : BaseClass
    {
        public string Name { get; set; }
        public virtual List<CatsProduct> CatsProducts { get; set; }
    }
}
