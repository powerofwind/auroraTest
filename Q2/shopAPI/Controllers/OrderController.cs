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
        private static List<Cart> orderproduct = new List<Cart>();

        [HttpPost]
        public void Post([FromBody] Order value)
        {
            var productCtr = new ShopController();
            var allProducts = productCtr.Get().Value;

            var selectedProduct = allProducts.FirstOrDefault(it => it.Name == value.Name);
            if (selectedProduct == null)
            {
                return;
            }

            var addOrder = new Cart
            {
                Name = selectedProduct.Name,
                Price = selectedProduct.Price,
                Amount = value.Amount,
                Total = selectedProduct.Price * value.Amount,
                Discount = (selectedProduct.Price * value.Amount)-(new logic().discount(value.Amount, selectedProduct.Price))
            };
            orderproduct.Add(addOrder);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Cart>> Get()
        {
            return orderproduct;
        }
    }
}
