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
    public class c_Cobros_Transferencias


    {


        public int id { get; set; }
        public string Cve_Propietario { get; set; }
        public string CveConcepto { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public decimal Importe { get; set; }
        public byte[] Imagen_Comprobante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }

        public string Tarjeton { get; set; }
        public string Bimestre { get; set; }
        public string Fraccionamiento { get; set; }

        //public c_Cobros_Transferencias(string _Cve_Propietario, string _CveConcepto, string _Mes, string _Año, DateTime _Fecha_Transaccion, decimal _Importe,
        //                               byte[] _Imagen_Comprobante, DateTime _FechaRegistro, string _Observaciones, DateTime _FechaActualizacion, bool _Activo)
        //{
        //    //this.idNombre = _idNombre;
        //    this.Cve_Propietario = _Cve_Propietario;
        //    this.CveConcepto = _CveConcepto;
        //    this.Mes = _Mes;
        //    this.Año = _Año;
        //    this.Fecha_Transaccion = _Fecha_Transaccion;

        //    this.Importe = _Importe;
        //    this.Imagen_Comprobante = _Imagen_Comprobante;
        //    this.FechaRegistro = _FechaRegistro;
        //    this.Observaciones = _Observaciones;
        //    this.FechaActualizacion = _FechaActualizacion;
        //    this.Activo = _Activo;
        //}







        public int Registra_Cobro(c_Cobros_Transferencias cobro)
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
                SqlCommand cmd = new SqlCommand("Sp_Registra_cobros", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Cve_Propietario", SqlDbType.VarChar, 50).Value = cobro.Cve_Propietario;
                cmd.Parameters.Add("@CveConcepto", SqlDbType.VarChar, 50).Value = cobro.CveConcepto;
                cmd.Parameters.Add("@Mes", SqlDbType.VarChar, 50).Value = cobro.Mes;
                cmd.Parameters.Add("@Año", SqlDbType.VarChar, 10).Value = cobro.Año;
                cmd.Parameters.Add("@Fecha_Transaccion", SqlDbType.DateTime).Value = cobro.Fecha_Transaccion;
                cmd.Parameters.Add("@Importe", SqlDbType.Money).Value = cobro.Importe;
                cmd.Parameters.Add("@Imagen_Comprobante", SqlDbType.Image).Value = cobro.Imagen_Comprobante;
                cmd.Parameters.Add("@FechaRegistro", SqlDbType.DateTime, 100).Value = cobro.FechaRegistro;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 300).Value = cobro.Observaciones;
                cmd.Parameters.Add("@Tarjeton", SqlDbType.VarChar, 100).Value = cobro.Tarjeton;
                cmd.Parameters.Add("@Bimestre", SqlDbType.VarChar, 1).Value = cobro.Bimestre;
                cmd.Parameters.Add("@Fracc", SqlDbType.VarChar, 5).Value = cobro.Fraccionamiento;
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

        public int Actualiza_Cobro(c_Cobros_Transferencias cobro)
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
                SqlCommand cmd = new SqlCommand("Sp_Actualiza_cobros", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Cve", SqlDbType.VarChar, 50).Value = cobro.id;
                cmd.Parameters.Add("@Cve_Propietario", SqlDbType.VarChar, 50).Value = cobro.Cve_Propietario;
                cmd.Parameters.Add("@CveConcepto", SqlDbType.VarChar, 50).Value = cobro.CveConcepto;
                cmd.Parameters.Add("@Mes", SqlDbType.VarChar, 50).Value = cobro.Mes;
                cmd.Parameters.Add("@Año", SqlDbType.VarChar, 10).Value = cobro.Año;
                cmd.Parameters.Add("@Fecha_Transaccion", SqlDbType.DateTime).Value = cobro.Fecha_Transaccion;
                cmd.Parameters.Add("@Importe", SqlDbType.Money).Value = cobro.Importe;
                cmd.Parameters.Add("@Imagen_Comprobante", SqlDbType.Image).Value = cobro.Imagen_Comprobante;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 300).Value = cobro.Observaciones;
                cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = cobro.Activo;
                cmd.Parameters.Add("@Bimestre", SqlDbType.VarChar, 1).Value = cobro.Bimestre;
                cmd.Parameters.Add("@Fra", SqlDbType.VarChar, 5).Value = cobro.Fraccionamiento;
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


        public void Muestra_Cobros(DataGridView Data)
        {

            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_Cobros", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;

            daEmpresa.Fill(dsEmpresa, "Cobros");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Cobros";
            Data.Refresh();




        }

        public void Muestra_Cobros_Individual(DataGridView Data, string CvePropietario,string frac)
        {


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_Cobros_Propietario", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;
            daEmpresa.SelectCommand.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 100).Value = CvePropietario;
            daEmpresa.SelectCommand.Parameters.Add("@Fraccio", SqlDbType.VarChar, 5).Value = frac;



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
        public void Catalogo_Bimestres(ComboBox cb)
        {
            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter(" SELECT        Bimestre, Descripcion FROM   Bimiestres order by Bimestre ", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.Text;

            daEmpresa.Fill(dsEmpresa, "Bimiestres");

            cb.DataSource = dsEmpresa.Tables["Bimiestres"];
            cb.DisplayMember = "Descripcion";
            cb.ValueMember = "Bimestre";


        }



        public void Catalogo_Propietarios(ComboBox cb,string fra)
        {
            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();
            SqlDataAdapter daEmpresa = new SqlDataAdapter();


            if (fra == "1")
            {  daEmpresa = new SqlDataAdapter("SELECT Cve_Propietario, Nombre_Propietario FROM [dbo].[Propietarios_Andaman] where CveFraccionamiento =  '" + fra + "' ORDER BY ID ASC", oconexion.conexion); }
            else {
                 daEmpresa = new SqlDataAdapter("SELECT Cve_Propietario, Nombre_Propietario FROM [dbo].[Propietarios_Andaman] where CveFraccionamiento =  '" + fra + "' order by Cve_Propietario", oconexion.conexion);
            }

            
            daEmpresa.SelectCommand.CommandType = CommandType.Text;

            daEmpresa.Fill(dsEmpresa, "Propietarios");

            cb.DataSource = dsEmpresa.Tables["Propietarios"];
            cb.DisplayMember = "Cve_Propietario";
            cb.ValueMember = "Cve_Propietario";


        }

        public string Consulta_NombrePensionado(string cadena)
        {
            string Nombre = "";


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_BuscaPropietario", conn);
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

                            Nombre = (string)reader[0];


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



        public int TieneAdeudos(string cadena)
        {
            int Deudas = 0;



            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_TieneAdeudos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 10).Value = cadena;


                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Deudas = (int)reader[0];


                        }

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return Deudas;


        }
    }
}

