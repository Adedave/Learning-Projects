using First.Api.Model;
using System.Threading.Tasks;

namespace First.Api.Services
{
    public interface IGiphyServices
    {
        Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera);
    }
}
