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
    public class CatsproductDescriptionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsproductDescriptionController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetProductDescription")]
        public IEnumerable<CatsproductDescription> Get()
        {
            var data = _db.tbldescription.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetProductDescriptionById")]
        public ActionResult<CatsproductDescription> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tbldescription.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
