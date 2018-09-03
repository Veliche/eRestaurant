using SEDC.PracticalAspNet.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Data.Repository
{
    public class CategoryRepository : BaseRepository, IRepository<Category>
    {
        public Category Create(Category item)
        {
            DbContext.Categories.Add(item);
            DbContext.SaveChanges();
            return item;
        }

        public void Delete(Category item)
        {
            var dbItem = DbContext.Categories.Single(m =>
                m.Id == item.Id);
            DbContext.Categories.Remove(dbItem);
            DbContext.SaveChanges();
        }

        public Category Get(int id)
        {
            return DbContext.Categories.SingleOrDefault(
                m => m.Id == id);
        }

        public IList<Category> GetAll()
        {
            return DbContext.Categories.ToList();
        }

        public void Update(Category item)
        {
            var dbItem = DbContext.Categories.Single(m =>
                m.Id == item.Id);
            dbItem.Name = item.Name;
            DbContext.Entry<Category>(dbItem).State =
                System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
