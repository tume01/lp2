using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class ReunionRepository
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public ReunionRepository()
        {

        }

        public static int insertReunion(string fecha, string tema, string sugerencia, int codigoAlumno, int codigoProfesor)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into reunion (fecha,tema,sugerencias,alumno,profesor) values('" + fecha + "','" + tema + "','" + sugerencia + "','" + codigoAlumno + "','" + codigoProfesor + "');";

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch (Exception e)
            {
                connection.Close();
                return 0;
            }
        }
    }
}