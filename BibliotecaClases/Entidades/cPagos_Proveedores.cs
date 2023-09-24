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
    public class cPagos_Proveedores
    {
        public int id {get;set;}

        public string CveProveedor { get; set; }

        public DateTime FechaPago { get; set; }

        public Single Importe { get; set; }

        public string Observacones { get; set; }

        public byte[] Recibo_Imagen { get; set; }

        public string CveFraccionamiento { get; set; }



        public int Registra_PagosProveedores(cPagos_Proveedores cobro)
        {

            int Inserta = 0;
            cPagos_Proveedores ccobro = new cPagos_Proveedores();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SP_Registra_PagosProveedores", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CveProveedor", SqlDbType.VarChar, 50).Value = cobro.CveProveedor;
                cmd.Parameters.Add("@FechaPago", SqlDbType.DateTime).Value = cobro.FechaPago;
                cmd.Parameters.Add("@Importe", SqlDbType.Money).Value = cobro.Importe;
                cmd.Parameters.Add("@Observacones", SqlDbType.VarChar,200).Value = cobro.Observacones;
                cmd.Parameters.Add("@Recibo_Imagen", SqlDbType.Image).Value = cobro.Recibo_Imagen;
                cmd.Parameters.Add("@fra", SqlDbType. VarChar,5).Value = cobro.CveFraccionamiento;


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

        public int Registra_Actualiza_PagosProveedores(cPagos_Proveedores cobro)
        {

            int Inserta = 0;
            cPagos_Proveedores ccobro = new cPagos_Proveedores();



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SP_Actualiza_PagosProveedores", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cobro.id;
                cmd.Parameters.Add("@CveProveedor", SqlDbType.VarChar, 50).Value = cobro.CveProveedor;
                cmd.Parameters.Add("@FechaPago", SqlDbType.DateTime).Value = cobro.FechaPago;
                cmd.Parameters.Add("@Importe", SqlDbType.Money, 50).Value = cobro.Importe;
                cmd.Parameters.Add("@Observacones", SqlDbType.VarChar,200).Value = cobro.Observacones;
                cmd.Parameters.Add("@Recibo_Imagen", SqlDbType.Image).Value = cobro.Recibo_Imagen;
                cmd.Parameters.Add("@fra", SqlDbType.VarChar, 5).Value = cobro.CveFraccionamiento;



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

        public void Catalogo_Proveedores(ComboBox cb,String fra)
        {
            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("  select CveProveedor, Nombre_Proveedor from Proveedores where  CveFraccionamiento ='" + fra + "' order by Nombre_Proveedor asc", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.Text;

            daEmpresa.Fill(dsEmpresa, "Proveedores");

            cb.DataSource = dsEmpresa.Tables["Proveedores"];
            cb.DisplayMember = "Nombre_Proveedor";
            cb.ValueMember = "CveProveedor";


        }





        public void Muestra_Cobros(DataGridView Data,string fra)
        {

            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_PagosProveedores", oconexion.conexion);
            daEmpresa.SelectCommand.Parameters.Add("@fracc", SqlDbType.VarChar, 5).Value = fra;
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;

            daEmpresa.Fill(dsEmpresa, "Pagos");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Pagos";
            Data.Refresh();




        }

        public void Muestra_Cobros_Por_Proveddor(DataGridView Data,string cve)
        {

            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);
            DataSet dsEmpresa = new DataSet();

            SqlDataAdapter daEmpresa = new SqlDataAdapter("Sp_PagosProveedores_PorCve", oconexion.conexion);
            daEmpresa.SelectCommand.CommandType = CommandType.StoredProcedure;
            daEmpresa.SelectCommand.Parameters.Add("@CveProveedor", SqlDbType.VarChar, 5).Value = cve;

            daEmpresa.Fill(dsEmpresa, "Pagos");
            Data.DataSource = dsEmpresa;
            Data.DataMember = "Pagos";
            Data.Refresh();




        }



    }
}
