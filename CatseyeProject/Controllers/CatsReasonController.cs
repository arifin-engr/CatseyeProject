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
    public class CatsReasonController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsReasonController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetReason")]
        public IEnumerable<CatsReason> Get()
        {
            var data = _db.tblreasons.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetReasonById")]
        public ActionResult<CatsReason> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblreasons.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
