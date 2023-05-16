using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Models
{
    public class CatsApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
    }
}
