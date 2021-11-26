using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Repositories.Contrato;
using TemplateBackend.Services.Contrato;
using TemplateBackend.Services.Implementacao;

namespace TemplateBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly IServiceTeste _serviceTeste;
        private readonly ILogger<TesteController> _logger;

        public TesteController(IServiceTeste serviceTeste, ILogger<TesteController> logger)
        {
            _serviceTeste = serviceTeste;
            _logger = logger;
        }

        [HttpGet]
        [Route("retornoTesteAsync/{id}")]
        public async Task<IActionResult> RetornoTesteAsync(int id)
        {
            try
            {
                var retorno = await _serviceTeste.RetornoTesteAsync(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("retornoTeste/{id}")]
        public IActionResult RetornoTeste(int id)
        {
            try
            {
                var retorno = _serviceTeste.RetornoTeste(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("pegarValorBanco")]
        public IActionResult PegarValorBanco()
        {
            try
            {
                var retorno = _serviceTeste.PegaQualquerLista();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public IActionResult SetarValor([FromBody] string texto)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return new StatusCodeResult(500);
            }
        }



    }
}
