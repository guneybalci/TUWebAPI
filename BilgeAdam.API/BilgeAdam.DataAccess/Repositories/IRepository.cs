using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DataAccess.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        Task<int> Add(T entity);
        Task<IList<T>> GetAllItems();
        Task<T> GetItemById(int id);
        Task Update(T entity);
        Task Delete(int id);

    }
}
