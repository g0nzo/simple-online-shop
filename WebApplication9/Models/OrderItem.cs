using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebApplication9.Models
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}