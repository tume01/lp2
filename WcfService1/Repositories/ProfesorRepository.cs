using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class ProfesorRepository
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public ProfesorRepository()
        {

        }

        public static int insertProfesor(Profesor profesor)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into profesor (nombre,dni,correo,telefono,idioma,año,grado,especialidad,fechaIni,fechaRev,fechaFin,categoria,estutor) values('" + profesor.Nombre + "','" + profesor.Dni + "','" + profesor.Correo + "','" + profesor.Telefono + "','" + profesor.Idioma + "','" + profesor.AnosExp + "','" + profesor.GradoAcademico + "','" + profesor.Especialidad.Codigo + "','" + profesor.FechaIngreso + "','" + profesor.FechaRevalidacion + "','" + profesor.FechaFinCategoria + "','" + profesor.Categoria + "','1');";

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