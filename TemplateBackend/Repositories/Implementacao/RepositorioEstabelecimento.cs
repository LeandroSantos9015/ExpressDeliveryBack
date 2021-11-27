using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Models.Estabelecimento;
using TemplateBackend.Repositories.Contrato;

namespace TemplateBackend.Repositories.Implementacao
{
    public class RepositorioEstabelecimento : IRepositorioEstabelecimento
    {
        public readonly IRepositoryBase _repositoryBase;

        public RepositorioEstabelecimento(IRepositoryBase repository)
        {
            _repositoryBase = repository;
        }


        public IList<ModelListaEstabelecimento> ListarEstabelecimentos(int idCidade)
        {

            string query = "select * from ListarEmpresas()";

            var consulta = _repositoryBase.Connection.Query<ModelListaEstabelecimento>(query).ToList();

            return consulta;
        }
    }
}
