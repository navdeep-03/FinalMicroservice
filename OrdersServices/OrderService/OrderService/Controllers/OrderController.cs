using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        [HttpGet()]
        public List<Order> GetOrders()
        {

            return new List<Order>
            {
             new Order{OrderId=1,OrderAmount=300,OrderDate= System.DateTime.Now},
             new Order{OrderId=2,OrderAmount=500,OrderDate=System.DateTime.Now}
            };

        }
        [HttpGet("{Id}")]
        public List<Order> Get(int Id)
        {
            return new List<Order>
            {
             new Order{OrderId=1,OrderAmount=300,OrderDate= System.DateTime.Now},
             new Order{OrderId=2,OrderAmount=500,OrderDate=System.DateTime.Now}
            };


        }

    }
}