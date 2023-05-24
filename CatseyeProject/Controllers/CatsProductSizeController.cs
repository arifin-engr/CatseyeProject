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
    public class CatsProductSizeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsProductSizeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetProductSize")]
        public IEnumerable<CatsProductSize> Get()
        {
            var data = _db.ProductSizes.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetProductSizeById")]
        public ActionResult<CatsProductSize> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.ProductSizes.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
