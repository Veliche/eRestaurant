using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class Order
    {
        public int Id { get;}
        public string Comments { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Item> ItemList { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }
        private int TotalQuantity {
            get
            {
                return ItemList.Count;
            }
         }
    }
}
