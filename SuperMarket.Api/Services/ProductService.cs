using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Api.Domain.Models;
using SuperMarket.Api.Domain.Repositories;
using SuperMarket.Api.Domain.Services;
using SuperMarket.Api.Domain.Services.Communication;

namespace SuperMarket.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<ProductResponse> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public Task<ProductResponse> SaveAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductResponse> UpdateAsync(int id, Product product)
        {
            throw new System.NotImplementedException();
        }

    }
}
