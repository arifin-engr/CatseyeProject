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
    public class CatsOrderController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsOrderController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetOrder")]
        public IEnumerable<CatsOrder> Get()
        {
            var data = _db.tblOrder.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetOrderById")]
        public ActionResult<CatsOrder> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblOrder.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
