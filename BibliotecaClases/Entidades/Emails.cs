using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Entidades
{
    public class Emails
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string smtp { get; set; }
        public string Port { get; set; }
        public bool Activo { get; set; }

        public Emails Consulta_Emails()
        {
            Emails oEmail = new Emails();


            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Consulta_Emails", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            oEmail.id = (int)reader[0];
                            oEmail.Email = reader[1].ToString();
                            oEmail.Contraseña = reader[2].ToString();
                            oEmail.smtp = reader[3].ToString();
                            oEmail.Port = reader[4].ToString();



                        }

                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return oEmail;


        }

    }
}
