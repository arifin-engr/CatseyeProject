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
    public class CatsproductTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsproductTypeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetProductType")]
        public IEnumerable<CatsproductType> Get()
        {
            var data = _db.tblproductTypes.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetroductTypeById")]
        public ActionResult<CatsproductType> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblproductTypes.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
