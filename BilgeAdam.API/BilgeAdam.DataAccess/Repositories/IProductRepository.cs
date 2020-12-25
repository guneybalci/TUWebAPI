using BilgeAdam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IList<Product>> SearchProductByName(string name);
    }
}
