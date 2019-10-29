using SuperMarket.Api.Domain.Models;
using SuperMarket.Api.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarket.Api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
