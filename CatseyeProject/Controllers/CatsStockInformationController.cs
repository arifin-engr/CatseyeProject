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
    public class CatsStockInformationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsStockInformationController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetStockInformation")]
        public IEnumerable<CatsStockInformation> Get()
        {
            var data = _db.tblStockInformation.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetStockInformationById")]
        public ActionResult<CatsStockInformation> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblStockInformation.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
