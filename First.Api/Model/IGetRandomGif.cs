using System.Threading.Tasks;

namespace First.Api.Model
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera);
    }
}