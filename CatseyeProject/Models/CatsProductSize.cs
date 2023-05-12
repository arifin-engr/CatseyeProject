using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsProductSize : BaseClass
    {
        
        public string Size { get; set; }  
        public virtual ICollection<CatsProductdetails> CatsProductdetails { get; set; }
    }
}
