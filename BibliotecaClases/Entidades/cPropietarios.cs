using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Entidades
{
    public class cPropietarios
    {

        public int id { get; set; }
    
        public string Cve_Propietario { get; set; }

        public string   Nombre_Propietario { get; set; }
        public string Correo_Propietario { get; set; }
        public string Telefono { get; set; }



        public List<cPropietarios> CalalogoPropietarios( string id)


        {



            List<cPropietarios> Lpropietarios = new List<cPropietarios>();




            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_CatalogoPropietarios_Correo", conn);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 5).Value = id;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();




                    if (reader.HasRows)
                    {


                        while (reader.Read())
                        {
                            try
                            {
                                cPropietarios oPro = new cPropietarios();

                                oPro.id = (int)reader[0];
                                oPro.Cve_Propietario = (string)reader[1];
                                oPro.Nombre_Propietario = (string)reader[2];
                                oPro.Correo_Propietario = (string)reader[3];
                                //oPro.Telefono = (string)reader[4];



                                Lpropietarios.Add(oPro);
                            }
                            catch (Exception e)
                            { 
                            
                            }
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return Lpropietarios;

        
        
        
        }

        
    }
}
