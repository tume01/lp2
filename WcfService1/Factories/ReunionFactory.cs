using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace WcfService1
{
    public class ReunionFactory
    {
        public ReunionFactory()
        {

        }

        public static Reunion create(MySqlDataReader reader, int codigoAlumno, int codigoProfesor)
        {

            Alumno alumno = AlumnoPersistance.getAlumnoByCodigo(codigoAlumno);
            Profesor profesor = ProfesorPersistance.getProfesorByCodigo(codigoProfesor);
            string fecha = reader["fecha"].ToString();
            string tem = reader["tema"].ToString();
            string sug = reader["sugerencias"].ToString();
            return new Reunion(alumno, profesor, fecha, tem, sug);
        }
    }
}