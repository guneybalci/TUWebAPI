using BilgeAdam.Business.DataTransferObjects;
using BilgeAdam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.Extensions
{
    public static class Converters
    {
        public static List<ProductListDTO> ConvertToProductListDto(this IList<Product> products)
        {
            List<ProductListDTO> productListDTOs = new List<ProductListDTO>();
            foreach (var item in products)
            {
                productListDTOs.Add(new ProductListDTO
                {
                    CategoryId = item.CategoryId,
                    Description = item.Description,
                    Discount = item.Discount,
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Name,
                    Price = item.Price
                });
            }
            return productListDTOs;
        }

        public static Product ConvertToProductEntity(this AddRequestProductDto dto)
        {
            return new Product
            {
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                Discount = dto.Discount,
                ImageUrl = dto.ImageUrl,
                Name = dto.Name,
                Price = dto.Price
            };
        }

        public static ProductListDTO ConvertToProductItemDto(this Product product)
        {
            return new ProductListDTO
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Discount = product.Discount,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}
