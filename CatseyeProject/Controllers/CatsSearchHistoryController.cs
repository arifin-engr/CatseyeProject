using CatseyeProject.Context;
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
    public class CatsSearchHistoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsSearchHistoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetSearchHistory")]
        public IEnumerable<CatsSearchHistory> Get()
        {
            var data = _db.tblsearch.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetSearchHistoryById")]
        public ActionResult<CatsSearchHistory> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblsearch.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
