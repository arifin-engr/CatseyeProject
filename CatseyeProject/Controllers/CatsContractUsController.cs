﻿using CatseyeProject.Context;
using CatseyeProject.Models.DTOs;
using CatseyeProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CatseyeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsContractUsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsContractUsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetCatsContractUs")]
        public IEnumerable<catsContractUs> Get()
        {
            var data = _db.tblcontractus.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetCatsContractUs")]
        public ActionResult<catsContractUs> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblcontractus.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
