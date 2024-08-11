using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Models.Publicacoes;
using SocialMedia.Application.Services.Publicacoes;

namespace SocialMedia.API.Controllers
{
    [Route("api/publicacoes")]
    [ApiController]
    public class PublicacaoController : Controller
    {
        private readonly IPublicacaoService _publicacaoService;

        public PublicacaoController(IPublicacaoService publicacaoService)
        {
            _publicacaoService = publicacaoService;
        }

        [HttpPost("{idPerfil}")]
        public IActionResult Cadastro(int idPerfil, CreatePublicacaoInputModel model)
        {
            var result = _publicacaoService.Insert(idPerfil, model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _publicacaoService.Delete(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, UpdatePublicacaoInputModel model)
        {
            var result = _publicacaoService.Update(id, model);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet("PorId/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _publicacaoService.GetById(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Listagem/{idPerfil}")]
        public IActionResult GetAll(int idPerfil)
        {
            var result = _publicacaoService.GetAll(idPerfil);

            return Ok(result);
        }
    }
}
