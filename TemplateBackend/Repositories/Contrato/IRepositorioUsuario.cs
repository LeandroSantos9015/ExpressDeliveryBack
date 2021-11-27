using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Estabelecimento;
using TemplateBackend.Models.Usuario;

namespace TemplateBackend.Repositories.Contrato
{
    public interface IRepositorioUsuario
    {

        void SalvarUsuario(ModelSalvarUsuario s);

    }
}
