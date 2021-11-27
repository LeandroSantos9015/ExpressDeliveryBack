using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Services.Contrato
{
    public interface IEstabelecimentoService
    {
        string ListaEstabelecimentos(int idCidade);

    }
}
