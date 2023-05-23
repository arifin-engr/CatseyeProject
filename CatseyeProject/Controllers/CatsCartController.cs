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
    public class CatsCartController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsCartController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetCart")]
        public IEnumerable<CatsCart> Get()
        {
            var data = _db.tblCatsCart.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetCartById")]
        public ActionResult<CatsCart> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblCatsCart.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
