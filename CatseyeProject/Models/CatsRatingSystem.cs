using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsRatingSystem : BaseClass
    {
       
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public CatsProduct catsProduct { get; set; }
    }
}
