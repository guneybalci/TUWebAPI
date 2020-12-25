using BilgeAdam.Business.DataTransferObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilgeAdam.Business
{
    public interface IProductService
    {
        Task<int> AddProductAsync(AddRequestProductDto productDto);
        Task<List<ProductListDTO>> GetProducts();
    }
}