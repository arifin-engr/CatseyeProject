using System.Collections.Generic;

namespace CatseyeProject.Models.DTOs
{
    public class RequestResult
    {
    
        public bool Result { get; set; }
        public List<string> Errors { get; set; }
    }
}
