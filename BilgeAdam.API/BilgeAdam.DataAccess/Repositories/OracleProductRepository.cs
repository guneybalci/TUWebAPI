using BilgeAdam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DataAccess.Repositories
{
  public  class OracleProductRepository : IProductRepository
    {
        public Task<int> Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
