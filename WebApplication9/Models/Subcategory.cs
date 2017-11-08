using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebApplication9.Models
{
    public class Subcategory
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}