using OnlineStore.Model;
using OnlineStore.Repo.Interfaces;
using Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
    public class ProductServace : ProductInterFase
    {
        //private readonly IProductRepository _productRepository;



        //public ProductServace(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}
        public async Task<Product> GetProduct()
        {
            return new Product()
            {
                Id = 1,
                Name = "product 1",
                Price = 100,
                Description = "new laptop with best price"
            };
        }

        public async Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
            //return await _productRepository.GetProducts();
        }
    

    }

}
