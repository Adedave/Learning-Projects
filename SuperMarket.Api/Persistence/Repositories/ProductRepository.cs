using Microsoft.EntityFrameworkCore;
using SuperMarket.Api.Domain.Models;
using SuperMarket.Api.Domain.Repositories;
using SuperMarket.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Persistence.Repositories
{
    public class ProductRepository: BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public Task AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
