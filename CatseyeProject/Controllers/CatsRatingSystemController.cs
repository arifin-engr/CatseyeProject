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
    public class CatsRatingSystemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsRatingSystemController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetRatingSystem")]
        public IEnumerable<CatsRatingSystem> Get()
        {
            var data = _db.tblRating.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetRatingSystemById")]
        public ActionResult<CatsRatingSystem> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblRating.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
