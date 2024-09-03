using Application;
using BusinessModels;
using BusinessModels.Comands;
using Microsoft.AspNetCore.Mvc;

namespace WebHost.APIs.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GerenciamentoPessoaController : ControllerBase
    {
        private readonly GerenciamentoPessoaService _pessoaService;

        public GerenciamentoPessoaController(GerenciamentoPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IEnumerable<GerenciamentoPessoas> ObterPessoas()
        {
            var resultado = _pessoaService.ObterTodasPessoas();
            return resultado;
        }

        [HttpPost]
        public RegistrarPessoaDTO.Resultado RegistrarPessoa([FromBody] RegistrarPessoaDTO.Requisito requisito)
        {
            var resultado = _pessoaService.RegistrarPessoa(requisito);
            return resultado;
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarNome(Guid id, string novoNome)
        {
            try
            {
                _pessoaService.AtualizarNome(id, novoNome);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarEmail(Guid id, string novoEmail)
        {
            try
            {
                _pessoaService.AtualizarEmail(id, novoEmail);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarIdade(Guid id, int novaIdade)
        {
            try
            {
                _pessoaService.AtualizarIdade(id, novaIdade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPessoa(Guid id)
        {
            try
            {
                _pessoaService.DeletarPessoa(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
