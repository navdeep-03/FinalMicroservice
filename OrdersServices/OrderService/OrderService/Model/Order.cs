using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }
        public double OrderAmount { get; set; }

        public List<Order> Items { get; set; } = new List<Order>();

    }
}
