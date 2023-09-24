using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BibliotecaClases.Conexiones
{
    public class Conexion

    {
        public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
    }
}
