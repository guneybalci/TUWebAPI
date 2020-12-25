using BilgeAdam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DataAccess.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private BilgeadamDBEntities db = new BilgeadamDBEntities();
        public async Task<int> Add(Product entity)
        {
            db.Products.Add(entity);
            await db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var entity = await GetItemById(id);
            db.Products.Remove(entity);
            await db.SaveChangesAsync();

        }

        public async Task<IList<Product>> GetAllItems()
        {
            var products = await db.Products.ToListAsync();
            return products;

        }

        public async Task<Product> GetItemById(int id)
        {
            var item = await db.Products.FindAsync(id);
            return item;
        }

        public async Task<IList<Product>> SearchProductByName(string name)
        {
            var products = await db.Products.Where(x => x.Name.Contains(name)).ToListAsync();
            return products;
        }

        public async Task Update(Product entity)
        {
            db.Entry<Product>(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
