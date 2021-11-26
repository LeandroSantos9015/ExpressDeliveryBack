using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateBackend.Repositories
{
    public interface IRepositoryBase
    {
        public SqlConnection Connection { get; }

    }
}