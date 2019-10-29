using System.Threading.Tasks;
using First.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace First.Api.Controllers
{
    [Route("v1/giphy")]
    [ApiController]
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyServices _giphyServices;
        public GiphyController(IGiphyServices giphyServices)
        {
            _giphyServices = giphyServices;
        }

        [HttpGet]
        [Route("random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCritera);
            return Ok(result);
        }
    }
}