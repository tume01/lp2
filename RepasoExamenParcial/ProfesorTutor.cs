using System;
using System.Collections.Generic;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Controlador
{
    [Serializable]
    public class ProfesorTutor 
    {
        private Profesor profesor;
        public Profesor Profesor
        {
            get { return profesor; }
        }
        private List<Alumno> listaAlumno = new List<Alumno>();
        public List<Reunion> Reuniones
        {
            get { return listaReunion; }
        }
        internal List<Alumno> ListaAlumno
        {
            get { return listaAlumno; }
            set { listaAlumno = value; }
        }
        private List<Reunion> listaReunion = new List<Reunion>();

        public ProfesorTutor(Profesor profesor)
        {
            this.profesor = profesor;            
        }

        public string getNodoProfesor()
        {
             return profesor.Codigo + "-" + profesor.Nombre;
        }
        public int Codigo
        {
            get { return profesor.Codigo; }
        }

        internal void agregarAlumno(Alumno alumno)
        {
            listaAlumno.Add(alumno);
        }

        public void addReunion(Reunion newReunion)
        {
            this.listaReunion.Add(newReunion);
        }
        
        public int cantidadReuniones()
        {
            return this.listaReunion.Count;
        }
    }
}
