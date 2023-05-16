using CatseyeProject.Context;
using CatseyeProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CatseyeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CatsCustomersController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public CatsCustomersController(ApplicationDbContext db)
        {
            _db= db;
        }


        [Authorize]
      
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(List<string>), 200)]
        [ProducesResponseType(typeof(List<string>), 400)]

        [HttpGet]
        [Route("GetCustomers")]
        public IEnumerable<CatsCustomer> Get()
        {
            var data= _db.tblCustomers.ToList();
            return _db.tblCustomers.ToList();
        }
        
        //public IEnumerable GetCatsCustomer() 
        //{
        //    return _db.tblCustomer.ToList();
        //}
    }
}
