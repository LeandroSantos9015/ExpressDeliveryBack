using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Estabelecimento;

namespace TemplateBackend.Repositories.Contrato
{
    public interface IRepositorioEstabelecimento
    {
        public IList<ModelListaEstabelecimento> ListarEstabelecimentos(int idCidade);

    }
}
