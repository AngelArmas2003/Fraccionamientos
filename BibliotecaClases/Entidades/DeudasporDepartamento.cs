using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaClases.Entidades
{
   public  class DeudasporDepartamento
    {

        public int id { get; set; }
        public string CveFraccionamiento { get; set; }
        public string CvePropietario { get; set; }
        public string Concepto_Adeudo { get; set; }
        public Single Importe_Adeudo { get; set; }
        public bool Pagado { get; set; }
        public Single Afavor { get; set; }




        public void Muestra_Deuodas(DataGridView Data)
        {

            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_Adeudos_Propietarios", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;

            daEmpresa.Fill(dsEmpresa, "Cobros");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Cobros";
            Data.Refresh();


        }

        public void Muestra_Deudas_Individual(DataGridView Data, string CvePropietario)
        {


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_Adeudos_Propietarios_Propietario", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;
            daEmpresa.SelectCommand.Parameters.Add("@cve", SqlDbType.VarChar, 100).Value = CvePropietario;

            daEmpresa.Fill(dsEmpresa, "Deudas");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Deudas";
            Data.Refresh();

        }



        public int Crea_Reporte_Individual_udas(string cobro)
        {
            int Inserta = 0;
          


            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_Crea_ReporteIndividual_Deudas", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 50).Value = cobro;


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


        public int Registra_Adeudo(DeudasporDepartamento Deuda)
        {

            int Inserta = 0;
    



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SP_RegistraAdeudo", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 50).Value = Deuda.CvePropietario;
                cmd.Parameters.Add("@Concepto_Adeudo", SqlDbType.VarChar, 700).Value = Deuda.Concepto_Adeudo;
                cmd.Parameters.Add("@Importe_Adeudo", SqlDbType.Money).Value = Deuda.Importe_Adeudo;
                cmd.Parameters.Add("@Pagado", SqlDbType.Bit).Value = Deuda.Pagado;
                cmd.Parameters.Add("@Afavor", SqlDbType.Money).Value = Deuda.Afavor;
                cmd.Parameters.Add("@fracc", SqlDbType.VarChar,5).Value = Deuda.CveFraccionamiento;

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

        public int Actualiza_Deuda(DeudasporDepartamento Deuda)
        {
            int Inserta = 0;




            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SP_ActualizaAdeudo", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Deuda.id;
                cmd.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 50).Value = Deuda.CvePropietario;
                cmd.Parameters.Add("@Concepto_Adeudo", SqlDbType.VarChar, 200).Value = Deuda.Concepto_Adeudo;
                cmd.Parameters.Add("@Importe_Adeudo", SqlDbType.Money).Value = Deuda.Importe_Adeudo;
                cmd.Parameters.Add("@Pagado", SqlDbType.Bit).Value = Deuda.Pagado;
                cmd.Parameters.Add("@Afavor", SqlDbType.Money).Value = Deuda.Afavor;
                cmd.Parameters.Add("@fracc", SqlDbType.VarChar,5).Value = Deuda.CveFraccionamiento;
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
