using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Models.Conexoes;
using SocialMedia.Application.Services.Conexoes;

namespace SocialMedia.API.Controllers
{
    [Route("api/conexoes")]
    [ApiController]
    public class ConexaoController : Controller
    {
        private readonly IConexaoService _conexaoService;

        public ConexaoController(IConexaoService conexaoService)
        {
            _conexaoService = conexaoService;
        }

        [HttpPost]
        public IActionResult Cadastro(CreateConexaoInputModel model)
        {
            var result = _conexaoService.Insert(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, model);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _conexaoService.GetById(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var result = _conexaoService.Delete(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet("Listagem/{idPerfil}")]
        public IActionResult GetAll(int idPerfil)
        {
            var result = _conexaoService.GetAll(idPerfil);

            return Ok(result);
        }
    }
}
