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
        private static int count = 1;

        [HttpPost]
        public void Post([FromBody] interest value)
        {
            int sumMoney = 0;
            for (int i = 0; i < value.Yearcount; i++)
            {
                var newinterest = new interest
                {
                    Count = count++,
                    Money = value.Money,
                    Money2 = (value.Money*value.Interest)/100,
                    Interest = value.Interest,
                    Pay = new logic().interestLogic(value.Money, value.Interest),
                    Yearcount = value.Yearcount,
                };
                allinterest.Add(newinterest);
            }
        }
       

        [HttpGet]
        public ActionResult<IEnumerable<interest>> Get()
        {
            return allinterest;
        }

    }
}
