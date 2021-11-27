using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Services.Contrato;

namespace TemplateBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IEstabelecimentoService _service;
        private readonly ILogger<EstabelecimentoController> _logger;

        public EstabelecimentoController(IEstabelecimentoService service, ILogger<EstabelecimentoController> logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        [Route("listarEstabelecimentos")]
        
        public IActionResult ListarEstabelecimentos()
        {
            try
            {
                var retorno = _service.ListaEstabelecimentos(0);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return new StatusCodeResult(500);
            }

        }


    }

   
}
