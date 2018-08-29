using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class Menu
    {
        public int Id { get;}
        public MenuTypeEnum MenuType { get; set; }
        public string RestaurantName { get; set; }
        public List<Category> Categories { get; set; }
    }
}
