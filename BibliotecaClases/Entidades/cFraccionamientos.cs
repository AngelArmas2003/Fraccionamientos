using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Entidades
{
    public class cFraccionamientos
    {

        public int id { get; set; }
        public string CveFraccionamiento { get; set; }

        public string NombreFraccionamiento { get; set; }


        public List<cFraccionamientos> CalalogoFraccionamiento()


        {



            List<cFraccionamientos> LFraccionamientos = new List<cFraccionamientos>();




            Conexiones.Conexion oconexion = new Conexiones.Conexion();
            using (SqlConnection conn = new SqlConnection(oconexion.conexion.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_CatalogoFraccionamiento", conn);
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
                                cFraccionamientos oPro = new cFraccionamientos();

                                oPro.id = (int)reader[0];
                                oPro.CveFraccionamiento = Convert.ToString(reader[1]);
                                oPro.NombreFraccionamiento = Convert.ToString(reader[2]);




                                LFraccionamientos.Add(oPro);
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
            return LFraccionamientos;




        }


    }
}
