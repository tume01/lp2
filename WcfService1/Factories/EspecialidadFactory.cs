using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class EspecialidadFactory
    {
        public EspecialidadFactory()
        {

        }

        public static Especialidad create(MySqlDataReader reader)
        {
            int codigo = Int32.Parse(reader["codigo"].ToString());
            string nombre = reader["nombre"].ToString();
            return new Especialidad(codigo, nombre);
        }
    }
}