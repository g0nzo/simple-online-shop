using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public ApplicationUser User { get; set; }
        public Address Address { get; set; }
        public decimal TotalPrice { get; set; }
        public Status Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}