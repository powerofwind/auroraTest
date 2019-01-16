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
            // ดึงรายการสินค้าทั้งหมดที่มีมา
            var productCtr = new ShopController();
            var allProducts = productCtr.Get();

            //หาสินค้าที่ผู้ใช้เลือกซื้อว่ามีหรือเปล่า
            //TODO
            //var selectedProduct = allProducts.FirstOrDefault();
            // if (selectedProduct == null)
            // {
            //     // ไม่มีสินค้าที่ผู้ใช้เลือก ไม่ทำต่อ
            //     return;
            // }

            var neworder = new Order
            {
                Amount = value.Amount,
               // Total = value.price * value.amount
            };
            orderproduct.Add(neworder);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return orderproduct;
        }

        // [HttpPut("{name}")]
        // public void Put(string name, [FromBody] Products value)
        // {
        //     var selectedProduct = allproduct.FirstOrDefault(it => it.Name == name);
        //     if (selectedProduct == null)
        //     {
        //         return;
        //     }

        //     selectedProduct.Amount += value.Amount;




        // }
    }
}
