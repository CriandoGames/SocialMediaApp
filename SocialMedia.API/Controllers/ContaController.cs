using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Models.Contas;
using SocialMedia.Application.Models.Perfis;
using SocialMedia.Application.Services.Contas;

namespace SocialMedia.API.Controllers
{
    [Route("api/contas")]
    [ApiController]
    public class ContaController : Controller
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        [HttpPost]
        public IActionResult Cadastro(CreateContaInputModel model)
        {
            var result = _contaService.Insert(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, model);
        }

        [HttpGet("PorId/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _contaService.GetById(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("PorEmail/{email}")]
        public IActionResult GetByEmail(string email)
        {
            var result = _contaService.GetByEmail(email);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, UpdateContaInputModel model)
        {
            var result = _contaService.Update(id, model);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _contaService.Delete(id);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("MudarSenha/{email}")]
        public IActionResult MudarSenha(string email, UpdateSenhaContaInputModel model)
        {
            var result = _contaService.MudarSenha(email, model);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Login")]
        public IActionResult Login(string login, string senha)
        {
            var result = _contaService.Login(login, senha);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("{id}/perfil")]
        public IActionResult PostPerfil(int id, CreatePerfilInputModel model)
        {
            var result = _contaService.Perfil(id, model);

            if (!result.IsSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
}
}
