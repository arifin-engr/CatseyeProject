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
    public class CatsProductColorController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsProductColorController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetProductColor")]
        public IEnumerable<CatsProductColor> Get()
        {
            var data = _db.tblProductColors.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetProductColorById")]
        public ActionResult<CatsProductColor> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblProductColors.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
