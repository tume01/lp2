using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class ReunionPersistance
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";
        public ReunionPersistance()
        {

        }
        public static List<Reunion> getReunionesByProfesor(int codigo)
        {
            List<Reunion> lista = new List<Reunion>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select * from reunion where profesor =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int codigoAlumno = Int32.Parse(reader["alumno"].ToString());
                int codigoProfesor = Int32.Parse(reader["profesor"].ToString());
                Reunion newReunion = ReunionFactory.create(reader, codigoAlumno, codigoProfesor);
                lista.Add(newReunion);
            }
            connection.Close();
            return lista;
        }
        public static List<Reunion> getReunionesByAlumno(int codigo)
        {
            List<Reunion> lista = new List<Reunion>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select * from reunion  where alumno =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int codigoAlumno = Int32.Parse(reader["alumno"].ToString());
                int codigoProfesor = Int32.Parse(reader["profesor"].ToString());
                Reunion newReunion = ReunionFactory.create(reader, codigoAlumno, codigoProfesor);
                lista.Add(newReunion);
            }
            connection.Close();

            return lista;
        }
    }
}