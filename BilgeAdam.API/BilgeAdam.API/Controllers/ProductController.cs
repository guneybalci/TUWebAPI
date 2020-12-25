using BilgeAdam.Business;
using BilgeAdam.Business.DataTransferObjects;
using BilgeAdam.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BilgeAdam.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            var repo = new EFProductRepository();
            var service = new ProductService(repo);
            List<ProductListDTO> productLists = await service.GetProducts();
            return Ok(productLists);
        }

        public async Task<IHttpActionResult> Get(int id)
        {
               var repo = new EFProductRepository();
               //var oracle = new OracleProductRepository();
            
            var service = new ProductService(repo);
            ProductListDTO product = await  service.getProductById(id);
            return Ok(product);
        }

        public async Task<IHttpActionResult> Post([FromBody] AddRequestProductDto productDto)
        {
            var repo = new EFProductRepository();
            var service = new ProductService(repo);
           int id =  await service.AddProductAsync(productDto);
            return CreatedAtRoute("DefaultApi", new { id = id},id);


        }

    }
}
