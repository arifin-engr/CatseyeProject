using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsProductColor : BaseClass
    {

        [Display(Name ="Color Name")]
        public string ColorName { get; set; }  
    }
}
