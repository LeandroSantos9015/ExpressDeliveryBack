using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Usuario;
using TemplateBackend.Repositories.Contrato;
using TemplateBackend.Services.Contrato;

namespace TemplateBackend.Services.Implementacao
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepositorioUsuario _repositorio;
        private readonly ILogger<UsuarioService> _logger;

        public UsuarioService(IRepositorioUsuario repositorioUsuario, ILogger<UsuarioService> logger)
        {
            _repositorio = repositorioUsuario;
            _logger = logger;
        }

        public void SalvarUsuario(ModelSalvarUsuario account)
        {
            _repositorio.SalvarUsuario(account);
        }

    }
}
