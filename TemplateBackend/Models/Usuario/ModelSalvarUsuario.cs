using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Models.Usuario
{
    public class ModelSalvarUsuario
    {

        public Int64? Id { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public String Telefone { get; set; }

        public bool UserEmpresa { get; set; }

        public bool Ativo { get; set; }
    }
}