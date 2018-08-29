using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class Item
    {
        public int Id { get;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

    }
}
