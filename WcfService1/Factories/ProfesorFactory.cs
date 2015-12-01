using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class ProfesorFactory
    {
        public ProfesorFactory()
        {

        }

        public static Profesor create(MySqlDataReader reader)
        {
            string nombre = reader["nombre"].ToString();
            int dni = Int32.Parse(reader["dni"].ToString());
            int codigo = Int32.Parse(reader["codigo"].ToString());
            string correo = (reader["correo"].ToString());
            int telefono = Int32.Parse(reader["telefono"].ToString());
            string regimen = "";
            int anio = Int32.Parse(reader["año"].ToString());
            string grado = reader["grado"].ToString();
            int codigoEspecialidad = Int32.Parse(reader["especialidad"].ToString());
            Especialidad especialidad = EspecialidadPersistance.getEspecialidadByCodigo(codigoEspecialidad);
            string fIn = reader["fechaIni"].ToString();
            string fRe = reader["fechaRev"].ToString();
            string fFin = reader["fechaFin"].ToString();
            int idioma = Int32.Parse(reader["idioma"].ToString());
            string categoria = reader["categoria"].ToString();

            return new Profesor(codigo, nombre, dni, correo, telefono, regimen, idioma, anio, grado, especialidad, fIn, fRe, fFin, categoria);
        }
    }
}