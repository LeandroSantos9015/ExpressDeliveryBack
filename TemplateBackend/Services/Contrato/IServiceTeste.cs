using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Services.Contrato
{
    public interface IServiceTeste
    {
        public Task<string> RetornoTesteAsync(int id);

        public string RetornoTeste(int id);

        public Task<string> PegaQualquerLista();

    }
}
