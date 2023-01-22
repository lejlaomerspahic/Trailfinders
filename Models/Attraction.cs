
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trailfinders.Models
{
    public class Attraction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string Information { get; set; }
        public int Price { get; set; }
    }
}

