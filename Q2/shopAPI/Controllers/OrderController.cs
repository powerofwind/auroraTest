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
            var allProducts = productCtr.Get().Value;

            //หาสินค้าที่ผู้ใช้เลือกซื้อว่ามีหรือเปล่า
            var selectedProduct = allProducts.FirstOrDefault(it => it.Name == value.Name);
            if (selectedProduct == null)
            {
                return;
            }

            // มีสินค้าที่ผู้ใช้เลือก ทำการบันทึกประวัติการสั่งซื้อ
            var addOrder = new Cart
            {
                Name = selectedProduct.Name,
                Price = selectedProduct.Price,
                Amount = value.Amount,
                Total = selectedProduct.Price * value.Amount,
            };
            orderproduct.Add(addOrder);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Cart>> Get()
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
