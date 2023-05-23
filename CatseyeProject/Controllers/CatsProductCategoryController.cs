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
    public class CatsProductCategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CatsProductCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetProductCategory")]
        public IEnumerable<CatsProductCategory> Get()
        {
            var data = _db.tblProductCategory.ToList();
            return data;
        }


        [HttpGet]
        [Route("GetProductCategoryById")]
        public ActionResult<CatsProductCategory> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var data = _db.tblProductCategory.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(data);
        }
    }
}
