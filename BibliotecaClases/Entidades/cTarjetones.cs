using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Entidades
{
    public class cTarjetones
    {

            public int id   {get;set;}
            public string Conteo_Tarjeton  {get;set;}
            public string Ultimo_Tarjeton_Creado{ get; set; }

        public string Numero_Tarjeton { get; set; }
        public string CvePropietario { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public DateTime Vigencia_Inicio { get; set; }
        public DateTime Vigencia_Final { get; set; }
        public DateTime Fecha_Emision { get; set; }








        public string Obtiene_Folio_Boleto()
        {
            string oBoleto = null;



            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(" declare @valor int set @valor =(Select Conteo_Tarjeton from Conteo_Tarjetones) if @valor=9999999 UPDATE Conteo_Tarjetones set [Conteo_Tarjeton] = 1  Select Conteo_Tarjeton from Conteo_Tarjetones", conn);
                cmd.CommandType = CommandType.Text;


                try
                {
                    conn.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            oBoleto = reader[0].ToString();



                            if (oBoleto.Length < 7)
                            {

                                for (int cl = oBoleto.Length; cl <= 7; cl++)
                                {
                                    oBoleto = "0" + oBoleto;
                                    cl = (oBoleto.Length);
                                }
                            }

                        }



                    }
                    else
                    {
                        return oBoleto;
                    }


                    return oBoleto;


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return oBoleto;


        }

        public int Registra_tarjeton(cTarjetones tarjetom)
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
                SqlCommand cmd = new SqlCommand("Sp_RegsitraTarjeton", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Numero_Tarjeton", SqlDbType.VarChar, 50).Value = tarjetom.Numero_Tarjeton;
                cmd.Parameters.Add("@CvePropietario", SqlDbType.VarChar, 50).Value = tarjetom.CvePropietario;
                cmd.Parameters.Add("@Mes", SqlDbType.VarChar, 50).Value = tarjetom.Mes;
                cmd.Parameters.Add("@Año", SqlDbType.VarChar, 10).Value = tarjetom.Año;
                cmd.Parameters.Add("@Vigencia_Inicio", SqlDbType.DateTime).Value = tarjetom.Vigencia_Inicio;
                cmd.Parameters.Add("@Vigencia_Final", SqlDbType.DateTime).Value = tarjetom.Vigencia_Final;
                cmd.Parameters.Add("@Fecha_Emision", SqlDbType.DateTime).Value = tarjetom.Fecha_Emision;




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
        public int Crea_Tarjeton(string tarjeton)
        {
            int Inserta = 0;
            



            try
            {
                Conexiones.Conexion oconexion = new Conexiones.Conexion();

                SqlConnection oConecta = new SqlConnection(oconexion.conexion.ConnectionString);

                // Ejecución de sentencias SQL
                // ---------------------------


                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Sp_Tarjeton", oconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Tarjeton", SqlDbType.VarChar, 50).Value = tarjeton;


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
