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
            for (int i = 0; i < value.Yearcount; i++)
            {
                var newinterest = new interest
                {
                    Count = count++,
                    Interest = value.Interest,
                    Yearcount = value.Yearcount,
                    Money = value.Money,
                    Pay = new logic().interestLogic(value.Money, value.Interest)

                };
                allinterest.Add(newinterest);
            }


        }
        //  double sumTotal = 0;
        //     double sumAmount = 0;

        //     for (var i = 0; i < allproduct.Count; i++)
        //     {
        //         sumTotal += allproduct[i].Total;
        //         sumAmount += allproduct[i].Amount;
        //     }

        //    double productAVG = (sumTotal / sumAmount);

        //     var allAVG = new ProductsAVG
        //     {
        //         ProductGroup = allproduct,
        //         Average = Math.Round(productAVG, 2)
        //     };
        //     return allAVG;


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
