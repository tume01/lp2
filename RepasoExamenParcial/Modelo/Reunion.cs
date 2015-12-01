using System;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public class Reunion
    {
        Alumno alumno;
        Profesor profesor;
        DateTime fecha;
        string tema;
        string sugerencias;

        public Reunion() { 
            
        }
        public DateTime FechaValue
        {
            get { return fecha; }
        }
        public Profesor Profesor
        {
            get { return profesor; }
        }
        public Reunion(Alumno a,Profesor p, DateTime t,string tem,string sug) {
            alumno=a;
            profesor=p;
            fecha=t;
            tema=tem;
            sugerencias=sug;
        }

        public string ProfesorName
        {
            get { return profesor.Nombre; }
        }

        public string fechaReunion
        {
            get { return fecha.ToString("yyyy-MM-dd"); }
        }

        public string Tema
        {
            get { return this.tema; }
        }
    }
}
