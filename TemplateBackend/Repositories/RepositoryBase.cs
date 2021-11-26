using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Repositories
{
    public class RepositoryBase : IRepositoryBase
    {
        public SqlConnection Connection { get; private set; }

        public RepositoryBase(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("SQLServer");

            Connection = new SqlConnection(connectionString);
        }
    }
}