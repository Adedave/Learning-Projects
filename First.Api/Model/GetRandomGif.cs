using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace First.Api.Model
{
    public class GetRandomGif : IGetRandomGif
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "ld6mC6tE0YqinLqbwWAh9Fe6rIZas4S7";

            var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");


            var response = await Client.GetAsync(url);
            DateTime dateTime = DateTime.Now;
            var kind = dateTime.Kind;
            var ed = DateTimeOffset.Now;
            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<GiphyModel>(json);
        }
    }
}
