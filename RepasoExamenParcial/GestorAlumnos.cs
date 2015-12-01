using System.Collections.Generic;
using Modelo;
namespace Controlador
{
    class GestorAlumnos
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public static List<Alumno> Alumnos
        {
            get { return GestorAlumnos.alumnos; }
            set { GestorAlumnos.alumnos = value; }
        }
                
        /// <summary>
        /// Este método busca un alumno en la lista
        /// dado su código.
        /// </summary>
        /// <param name="p"> Código del alumno
        public static Alumno buscarAlumno(int codigo)
        {
            return alumnos.Find(x => x.Codigo == codigo);
            
        }

        public static void addReunion(int codigoAlumno, Reunion newReunion)
        {
            Alumno alumno = buscarAlumno(codigoAlumno);

            alumno.listaReunion.Add(newReunion);
        }
    }
}
