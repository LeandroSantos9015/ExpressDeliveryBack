using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Repositories.Contrato;
using TemplateBackend.Services.Contrato;

namespace TemplateBackend.Services.Implementacao
{
    public class EstabelecimentoService : IEstabelecimentoService
    {
        private readonly IRepositorioEstabelecimento _repositorioEstabelecimento;
        private readonly ILogger<EstabelecimentoService> _logger;



        public EstabelecimentoService(IRepositorioEstabelecimento repositorio, ILogger<EstabelecimentoService> logger)
        {
            _repositorioEstabelecimento = repositorio;
            _logger = logger;


        }

        public string ListaEstabelecimentos(int idCidade)
        {
            var retorno = _repositorioEstabelecimento.ListarEstabelecimentos(0);

            var serializa = JsonConvert.SerializeObject(retorno);

            return serializa;
        }
    }
}
