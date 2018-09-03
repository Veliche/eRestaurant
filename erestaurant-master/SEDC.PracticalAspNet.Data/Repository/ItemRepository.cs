using SEDC.PracticalAspNet.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Data.Repository
{
    public class ItemRepository : BaseRepository, IRepository<Item>
    {
        public Item Create(Item item)
        {
            DbContext.Items.Add(item);
            DbContext.SaveChanges();
            return item;
        }

        public void Delete(Item item)
        {
            var dbItem = DbContext.Items.Single(i => i.Id == item.Id);
            DbContext.Items.Remove(dbItem);
            DbContext.SaveChanges();
        }

        public Item Get(int id)
        {
            return DbContext.Items.SingleOrDefault(i => i.Id == id);
        }

        public IList<Item> GetAll()
        {
            return DbContext.Items.ToList();
        }

        public void Update(Item item)
        {
            var dbItem = DbContext.Items.Single(i => i.Id == item.Id);
            dbItem.Name = item.Name;
            dbItem.Price = item.Price;
            dbItem.Description = item.Description;
            dbItem.Contents = item.Contents;
        }
    }
}
