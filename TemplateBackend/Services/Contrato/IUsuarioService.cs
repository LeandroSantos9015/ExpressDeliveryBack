using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Usuario;

namespace TemplateBackend.Services.Contrato
{
    public interface IUsuarioService
    {

        void SalvarUsuario(ModelSalvarUsuario account);
    }
}
