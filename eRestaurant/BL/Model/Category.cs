using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Menu Menu { get; set; }
        public List<Item> ItemList { get; set; }
    }
}
