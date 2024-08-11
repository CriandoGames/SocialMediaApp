using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Services.Feeds;

namespace SocialMedia.API.Controllers
{
    [Route("api/feeds")]
    [ApiController]
    public class FeedController : Controller
    {
        private readonly IFeedService _feedService;

        public FeedController(IFeedService feedService)
        {
            _feedService = feedService;
        }

        [HttpGet("Listagem/{idPerfil}")]
        public IActionResult ObterFeed(int idPerfil, int pagina = 0, int tamanho = 10)
        {
            var result = _feedService.GetAll(idPerfil, pagina, tamanho);

            return Ok(result);
        }
    }
}
