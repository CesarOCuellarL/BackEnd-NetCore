using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using webapi_csharp.Modelos;

namespace webapi_csharp.DB
{
    public class DBConnection:DbContext
    {
        public DBConnection(DbContextOptions<DBConnection> options):base(options)
        {

        }

        public DbSet<Humano> Humano { get; set; }
    }
}
