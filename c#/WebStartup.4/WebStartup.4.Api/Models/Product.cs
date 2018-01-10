using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStartup._4.Api.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
    }
}
