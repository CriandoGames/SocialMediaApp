using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Models.Perfis;
using SocialMedia.Application.Services.Perfis;

namespace SocialMedia.API.Controllers
{
    [Route("api/perfis")]
    [ApiController]
    public class PerfilController : Controller
    {
        private readonly IPerfilService _perfilService;

        public PerfilController(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, UpdatePerfilInputModel model)
        {
            var result = _perfilService.Update(id, model);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _perfilService.GetById(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpGet("Listagem/{contaId}")]
        public IActionResult GetAll(int contaId)
        {
            var result = _perfilService.GetAll(contaId);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _perfilService.Delete(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
