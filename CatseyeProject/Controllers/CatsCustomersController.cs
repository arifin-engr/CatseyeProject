﻿using CatseyeProject.Context;
using CatseyeProject.Models;
using CatseyeProject.Models.DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CatseyeProject.Controllers
{
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    
    public class CatsCustomersController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public CatsCustomersController(ApplicationDbContext db)
        {
            _db= db;
        }


        [HttpGet]
        [Route("GetCustomers")]
        public IEnumerable<CatsCustomer> Get()
        {
            var data= _db.tblCustomers.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetCustomerById")]
        public ActionResult<CatsCustomer> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblCustomers.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }


    }
}
