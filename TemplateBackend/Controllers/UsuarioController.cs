using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Usuario;
using TemplateBackend.Services.Contrato;

namespace TemplateBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(IUsuarioService service, ILogger<UsuarioController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        [Route("salvarUsuario")]
        public IActionResult ListarUsuarios([FromBody] ModelSalvarUsuario account)
        {
            try
            {
                _service.SalvarUsuario(account);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro XXXXX");
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }

}