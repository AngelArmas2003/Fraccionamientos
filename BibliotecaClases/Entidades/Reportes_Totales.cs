using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Entidades
{
  public  class Reportes_Totales
    {
        public int Reporte_Deudoresmantenimiento(string mes,string año,string fra)
        {
            int Inserta = 0;
          



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_Rep_PendientesMantenimiento", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Mes", SqlDbType.VarChar, 50).Value = mes;
                cmd.Parameters.Add("@Año", SqlDbType.VarChar, 50).Value = año;
                cmd.Parameters.Add("@fracc", SqlDbType.VarChar, 5).Value = fra;


                cmd.Connection.Open();
                Inserta = cmd.ExecuteNonQuery();
                cmd.Connection.Close();



                return Inserta;
            }
            catch (Exception e)
            {
                return Inserta;
            }



        }
        public int Reporte_DeudoresLuz( string año, string bimestre,string fra)
        {
            int Inserta = 0;




            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_DeudoresLuz", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
     
                cmd.Parameters.Add("@Año", SqlDbType.VarChar, 50).Value = año;
                cmd.Parameters.Add("@Bimestre", SqlDbType.VarChar, 50).Value = bimestre;
                cmd.Parameters.Add("@fracc", SqlDbType.VarChar, 5).Value = fra;

                cmd.Connection.Open();
                Inserta = cmd.ExecuteNonQuery();
                cmd.Connection.Close();



                return Inserta;
            }
            catch (Exception e)
            {
                return Inserta;
            }



        }
    }
}
