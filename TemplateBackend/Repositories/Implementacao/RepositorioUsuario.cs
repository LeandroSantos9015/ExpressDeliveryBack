using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Estabelecimento;
using TemplateBackend.Models.Usuario;
using TemplateBackend.Repositories.Contrato;

namespace TemplateBackend.Repositories.Implementacao
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public readonly IRepositoryBase _repositoryBase;

        public RepositorioUsuario(IRepositoryBase repository)
        {
            _repositoryBase = repository;
        }

        public void SalvarUsuario(ModelSalvarUsuario s)
        {
            try
            {
                int result = _repositoryBase.Connection.Execute("SalvarUsuario", s, commandType: CommandType.StoredProcedure, commandTimeout: 0);

                result.ToString();
               
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}