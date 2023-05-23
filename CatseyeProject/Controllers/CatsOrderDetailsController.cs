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
    public class CatsOrderDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsOrderDetailsController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetOrderDetails")]
        public IEnumerable<CatsOrderDetails> Get()
        {
            var data = _db.tblOrderDetails.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetOrderDetailsById")]
        public ActionResult<CatsOrderDetails> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblOrderDetails.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
