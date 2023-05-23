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
    public class BrowserCountsController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public BrowserCountsController(ApplicationDbContext db)
        {
            _db = db;
        }



        [HttpGet]
        [Route("GetBrowserCount")]
        public IEnumerable<BrowserCount> Get()
        {
            var data = _db.tblBrowserCount.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetBrowserCountById")]
        public ActionResult<BrowserCount> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblBrowserCount.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }

    }
}
