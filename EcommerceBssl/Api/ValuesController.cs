using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBssl.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceBssl.Api
{
    


    public class valuesViewModel
    {
        public string ActualAddress{ get; set; }
    }
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
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
        // GET api/<controller>/5 with morethan 1 param
        [HttpGet("ByName")]
        public string Get([FromQuery]int id, [FromQuery]string name)
        {
            return $"Your name is {name} and your ID is {id}";
        }
        // GET api/<controller>/5 with morethan 1 param
        [HttpGet("AllAddress")]
        public IActionResult GetAddressById([FromQuery]int id)
        {
            try
            {
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
                var req = listofAddress.FirstOrDefault(m => m.Id == id);

                if (req == null)
                {
                    return NotFound($"No Address found for id:{id}");
                }

                return Ok(req);
            }
            catch (Exception)
            {

               return NotFound($"Error processing Address for id:{id}");
            }
        }
        // GET api/<controller>/5 with morethan 1 param
        [HttpGet("AddressById2")]
        public List<Address> GetAddressById()
        {
            var listofAddress = new List<Address>
            {
                new Address
                {
                    Id=1,
                    ActualAddress="john"
                },
                new Address
                {
                    Id=2,
                    ActualAddress="john"
                },
            };
            var req = listofAddress;

            return req;
        }
       
        [HttpGet("AllAddress2")]
        public List<valuesViewModel> GetAllAddress2()
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
            var data = listofAddress.Select(x => new valuesViewModel { ActualAddress = x.ActualAddress }).ToList();
            return data;

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
