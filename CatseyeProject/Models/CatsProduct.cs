using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatseyeProject.Models
{
    public class CatsProduct : BaseClass
    {

 
       
        public int CollectionId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public bool Islive { get; set; } = false;

        public string Tag { get; set; }
        public string NameTag { get; set; }                                
        public string Discription { get; set; }
        public string Image { get; set; }
      
        public string Sizechart { get; set; }    
        public int TypeId { get; set; }       
        [ForeignKey("TypeId")]
        public virtual CatsproductType CatsproductType { get; set; }
        [ForeignKey("CollectionId")]
        public virtual CatsCollection CatsCollection { get; set; }       
       
        public virtual ICollection<CatsProductdetails> CatsProductdetails { get; set; }
        public virtual ICollection<CatsproductDescription> CatsproductDescriptions { get; set; }

    }
}
