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
    public class cRecibo_Luz

    {
        public int id  { get; set; }
        public  byte[] Recibo_Imagen { get; set; }

        public Single Importe { get; set; }

        public  DateTime FechaLimetePago { get; set; }

        public DateTime PeriodoInicio { get; set; }

        public DateTime PerioroFinal { get; set; }

        public bool Pagado { get; set; }

        public int Total_Departamentos { get; set; }

        public Single Importe_Departamento { get; set; }

        public string CveFraccionamiento { get; set; }

        // metodos
        public int  Registra_Recibo(cRecibo_Luz creciboobro)
        {

            int Inserta = 0;
            cRecibo_Luz crecibo = new cRecibo_Luz();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SP_Registra_Recibo", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Recibo_Imagen", SqlDbType.Image).Value = creciboobro.Recibo_Imagen;
                cmd.Parameters.Add("@Importe", SqlDbType.Money).Value = creciboobro.Importe;
                cmd.Parameters.Add("@FechaLimetePago", SqlDbType.DateTime).Value = creciboobro.FechaLimetePago;
                cmd.Parameters.Add("@PeriodoInicio", SqlDbType.DateTime).Value = creciboobro.PeriodoInicio;
                cmd.Parameters.Add("@PerioroFinal", SqlDbType.DateTime).Value = creciboobro.PerioroFinal;
                cmd.Parameters.Add("@Pagado", SqlDbType.Bit).Value = creciboobro.Pagado;
                cmd.Parameters.Add("@Total_Departamentos", SqlDbType.Int).Value = creciboobro.Total_Departamentos;
                cmd.Parameters.Add("@Importe_Departamento", SqlDbType.VarChar, 100).Value = creciboobro.Importe_Departamento;
                cmd.Parameters.Add("@Fracc", SqlDbType.VarChar, 5).Value = creciboobro.CveFraccionamiento;



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

        public int Actualiza_Cobro(cRecibo_Luz cobro)
        {
            int Inserta = 0;
            c_Cobros_Transferencias ccobro = new c_Cobros_Transferencias();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_ActualizaRecibosLuz", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cobro.id;
                cmd.Parameters.Add("@Recibo_Imagen", SqlDbType.Image).Value  = cobro.Recibo_Imagen;
                cmd.Parameters.Add("@Importe", SqlDbType.Money  ).Value = cobro.Importe;
                cmd.Parameters.Add("@FechaLimetePago", SqlDbType.DateTime).Value = cobro.FechaLimetePago;
                cmd.Parameters.Add("@PeriodoInicio", SqlDbType.DateTime).Value = cobro.PeriodoInicio;
                cmd.Parameters.Add("@PerioroFinal", SqlDbType.DateTime).Value = cobro.PerioroFinal;
                cmd.Parameters.Add("@Pagado", SqlDbType.Bit).Value = cobro.Pagado;
                cmd.Parameters.Add("@Total_Departamentos", SqlDbType.Int).Value = cobro.Total_Departamentos;
                cmd.Parameters.Add("@Importe_Departamento", SqlDbType.Money).Value = cobro.Importe_Departamento;
                cmd.Parameters.Add("@Fracc", SqlDbType.VarChar, 5).Value = cobro.CveFraccionamiento;


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

        public int Crea_Reporte_Individual(string cobro)
        {
            int Inserta = 0;
            c_Cobros_Transferencias ccobro = new c_Cobros_Transferencias();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_Crea_ReporteIndividual", oconexion.conexion);
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
        public int Cancela_Cobro(string idCobro)
        {
            int reg = 0;
            c_Cobros_Transferencias ccobro = new c_Cobros_Transferencias();

            return reg;



        }


        public void Muestra_Cobros(DataGridView Data,string fra)
        {

            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_MuestraReciboLuz", oconexion.conexion);
            daEmpresa.SelectCommand.Parameters.Add("@fracc", SqlDbType.VarChar, 5).Value = fra;
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;

            daEmpresa.Fill(dsEmpresa, "Luz");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Luz";
            Data.Refresh();




        }

        public void Muestra_Cobros_Individual(DataGridView Data, string CvePropietario)
        {


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_Cobros_Propietario", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;
            daEmpresa.SelectCommand.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 100).Value = CvePropietario;

            daEmpresa.Fill(dsEmpresa, "Cobros");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Cobros";
            Data.Refresh();

        }

        public void Catalogo_Movimientos(ComboBox cb)
        {
            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter(" select CveConcepto,Concepto from Conceptos order by id", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.Text;

            daEmpresa.Fill(dsEmpresa, "Conceptos");

            cb.DataSource = dsEmpresa.Tables["Conceptos"];
            cb.DisplayMember = "Concepto";
            cb.ValueMember = "CveConcepto";


        }


        public void Catalogo_Propietarios(ComboBox cb)
        {
            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("SELECT Cve_Propietario, Nombre_Propietario FROM [dbo].[Propietarios_Andaman]ORDER BY ID ASC", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.Text;

            daEmpresa.Fill(dsEmpresa, "Propietarios");

            cb.DataSource = dsEmpresa.Tables["Propietarios"];
            cb.DisplayMember = "Cve_Propietario";
            cb.ValueMember = "Cve_Propietario";


        }

        public string Consulta_Numero_Depto(string fra)
        {
            string Nombre = "";


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) as 'Deptos' from Propietarios_Andaman where CveFraccionamiento ='" + fra + "'", conn);
                cmd.CommandType = CommandType.Text;

               

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Nombre = Convert.ToString(reader[0]);


                        }

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return Nombre;


        }

        public string Consulta_CorreoPensionado(string cadena)
        {
            string Correo = "";


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_BuscaCorreoPropietario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Cve", SqlDbType.VarChar, 50).Value = cadena;


                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Correo = (string)reader[0];


                        }

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return Correo;


        }

        public int Crea_Reporte_Recibo_Luz(string cobro)
        {
            int Inserta = 0;
            c_Cobros_Transferencias ccobro = new c_Cobros_Transferencias();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_Reporte_Recibo_Luz", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = cobro;


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
