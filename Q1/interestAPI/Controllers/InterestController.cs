using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace interestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        public static List<interest> allinterest = new List<interest>();

        [HttpPost]
        public void Post([FromBody] interest value)
        {
            var newinterest = new interest
            {
                Interest = value.Interest,
                
            };
            allinterest.Add(newinterest);

        }

      
        [HttpGet]
        public ActionResult<IEnumerable<interest>> Get()
        {
            return allinterest;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }




    }
}
