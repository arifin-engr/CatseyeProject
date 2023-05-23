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
    public class CatsHomebannercsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsHomebannercsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetHomebanners")]
        public IEnumerable<CatsHomebannercs> Get()
        {
            var data = _db.tblHomBanner.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetGetHomebannersById")]
        public ActionResult<CatsHomebannercs> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblHomBanner.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
