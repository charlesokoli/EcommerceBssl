using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBssl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceBssl.Api
{
    [Route("api/[controller]")]
    public class houseController : Controller
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;
        public houseController(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        
        public Maincategory Maincategory { get; set; }
        public SubCategory subCategory { get; set; }
        [HttpGet("AllAddress2")]
        public IActionResult GetAllAddress2()
        {
            //database
            //  var listofcategory= context. 
            var listofAddress = new List<Address>
            {
                new Address
                {
                    Id=1,
                    ActualAddress="john street"
                },
                new Address
                {
                    Id=2,
                    ActualAddress="coker road"
                },
            };
           //var data = listofAddress.Select(x => new valuesViewModel { ActualAddress = x.ActualAddress }).ToList();
            return Ok( listofAddress);

        }

        [HttpGet("MainCat")]
        public IActionResult GetMainCat()
        {
            var data = _context.Maincategories.ToList();
            return Ok(data);
        }

        [HttpGet("MainCatById")]
        public async Task<IActionResult> GetMainCatById([FromQuery]int? id)
        {
            try
            {
                if (id != null)
                {
                    Maincategory = await _context.Maincategories.FirstOrDefaultAsync(m => m.Id == id);
                    return Ok(Maincategory);
                }
                else
                {
                    return NotFound($"No Id found");
                }
            }
            catch (Exception)
            {

                return NotFound($"Error processing id:{id}");
            }
        }





        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
