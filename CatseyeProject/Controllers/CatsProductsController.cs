using CatseyeProject.Context;
using CatseyeProject.Models;
using CatseyeProject.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatseyeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsProductsController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public CatsProductsController(ApplicationDbContext db)
        {
            _db = db;
        }



        [HttpGet]
        [Route("GetProducts")]
        public IEnumerable<CatsProduct> Get()
        {
            var data = _db.tblProduct.ToList();
            return data;
        }

        [HttpGet]
        [Route("GetProductById")]
        public ActionResult<CatsProduct> GetById(int? id)
        {
            if (id == 0 && id == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            var product =  _db.tblProduct.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return BadRequest(new RequestResult() { Result = false, Errors = new List<string>() { "Not Found" } });
            }
            return Ok(product);
        }


       

    }
}
