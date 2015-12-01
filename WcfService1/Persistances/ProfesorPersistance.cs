using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class ProfesorPersistance
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public ProfesorPersistance()
        {

        }

        public static Profesor getProfesorByCodigo(int codigo)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "select * from profesor where codigo =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();
            Profesor newProfesor = null;
            while (reader.Read())
            {
                newProfesor = ProfesorFactory.create(reader);
            }

            connection.Close();
            return newProfesor;
        }
    }
}