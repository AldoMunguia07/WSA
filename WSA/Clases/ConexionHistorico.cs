using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces de conexión con SQL Server
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace WSA.Clases
{
    class ConexionHistorico
    {
        private static string connectionString = @"Data Source=(local)\sqlexpress;Initial Catalog=FADSA_PC;Integrated Security=True";
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
