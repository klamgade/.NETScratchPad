using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetCrud.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}