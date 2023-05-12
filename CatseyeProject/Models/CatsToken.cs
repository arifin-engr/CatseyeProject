using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsToken:BaseClass
    {
      
        public string TokenName { get; set; }
        public int Amountflat { get; set; }
        public float AmountPercentage { get; set; }
        public DateTime validationToDate { get; set; }
        public DateTime validationFromDate { get; set; }
        public bool IsRange { get; set; }
        public float RangeAmount { get; set; }
        public int ValidatePerson { get; set; }
        public bool Isactive { get; set; } = false;
     
    }
}
