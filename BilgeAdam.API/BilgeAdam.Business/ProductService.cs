using BilgeAdam.Business.DataTransferObjects;
using BilgeAdam.Business.Extensions;
using BilgeAdam.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<List<ProductListDTO>> GetProducts()
        {
            // TODO 1: Ürünleri, repository ile çek ve buraya gönder.
            var items = await productRepository.GetAllItems();
            return items.ConvertToProductListDto();

        }

        public async Task<int> AddProductAsync(AddRequestProductDto productDto)
        {
            var productEntity = productDto.ConvertToProductEntity();
            int id = await productRepository.Add(productEntity);
            return id;
        }

        public async Task<ProductListDTO> getProductById(int id)
        {
            var entity = await productRepository.GetItemById(id);
            ProductListDTO dto =  entity.ConvertToProductItemDto();
            return dto;

        }
    }
}
