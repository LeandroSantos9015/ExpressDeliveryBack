using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TemplateBackend.Repositories.Contrato;
using TemplateBackend.Services.Contrato;

namespace TemplateBackend.Services.Implementacao
{
    public class ServiceOutroTeste : IServiceOutroTeste
    {
        private readonly IRepositoryTesteInstancia _repositorioTeste;
        public ServiceOutroTeste(IRepositoryTesteInstancia repositorioTeste)
        {
            _repositorioTeste = repositorioTeste;
        }

        public string RetornoTeste(int id)
        {
            return (id * id).ToString();
        }

        public Task<string> RetornoTesteAsync(int id)
        {
            Thread.Sleep(id * 10);
            var temp = (id * id).ToString();

            return Task.FromResult(JsonConvert.SerializeObject(temp));
        }

        public Task<string> PegaQualquerLista()
        {
            var retornoBanco = _repositorioTeste.Listar();
            var convertido = JsonConvert.SerializeObject(retornoBanco);

            return Task.FromResult(convertido);
        }
    }
}