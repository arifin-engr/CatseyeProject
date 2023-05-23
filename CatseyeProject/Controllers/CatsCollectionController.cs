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
    public class CatsCollectionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsCollectionController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetCatsCollection")]
        public IEnumerable<CatsCollection> Get()
        {
            var data = _db.tblCollection.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetCatsCollectionById")]
        public ActionResult<CatsCollection> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblCollection.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
