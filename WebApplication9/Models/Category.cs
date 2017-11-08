using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebApplication9.Models
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<Subcategory> Subcategories { get; set; }
    }
}