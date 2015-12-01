using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class AlumnoPersistance
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";
        public AlumnoPersistance()
        {

        }

        public static Alumno getAlumnoByCodigo(int codigo)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "select * from alumno where codigo =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();
            Alumno newAlumno = null;
            while (reader.Read())
            {
                newAlumno = AlumnoFactory.create(reader);

            }

            connection.Close();
            return newAlumno;
        }

        public static List<Alumno> getAlumnosByProfesor(int codigo)
        {
            List<Alumno> lista = new List<Alumno>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select a.* from alumno as a where a.tutor =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Alumno newAlumno = AlumnoFactory.create(reader);
                lista.Add(newAlumno);
            }
            connection.Close();

            return lista;
        }
    }
}