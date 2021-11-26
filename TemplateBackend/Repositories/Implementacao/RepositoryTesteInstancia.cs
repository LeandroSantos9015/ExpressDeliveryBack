using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TemplateBackend.Repositories.Contrato;

namespace TemplateBackend.Repositories.Implementacao
{
    public class RepositoryTesteInstancia : IRepositoryTesteInstancia
    {
        private readonly IRepositoryBase _repositoryBase;
        public RepositoryTesteInstancia(IRepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public IEnumerable<dynamic> Listar()
        {
            string query = "Select * From Teste";

            var consulta = _repositoryBase.Connection.Query<dynamic>(query);

            return consulta;
        }

        public int Insert(string texto)
        {

            var query = "insert into sensor (texto) values (@texto)";

            var result = _repositoryBase.Connection.Execute(query, new
            {
                texto = texto
            });

            return result;
        }
    }
}