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
    class Conexion
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["VitalCareRx.Properties.Settings.ConnectionDB"].ConnectionString;
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
