using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static int count = 1;
        private static List<Products> allproduct = new List<Products>();

        [HttpPost]
        public void Post([FromBody] Products value)
        {
            var newproduct = new Products
            {
                Id = ($"P{count++}"),
                Name = value.Name,
                Price = value.Price,
                Amount = value.Amount,
            };
            allproduct.Add(newproduct);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            return allproduct;
        }

        [HttpPut("{name}")]
        public void Put(string name, [FromBody] Products value)
        {
            var selectedProduct = allproduct.FirstOrDefault(it => it.Name == name);
            if (selectedProduct == null)
            {
                return;
            }

            selectedProduct.Amount += value.Amount;




        }
    }
}
