using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Modelo
{
    [Serializable]
    public abstract class Alumno : Persona
    {
        private int ciclo;
        private int creditos;
        private List<Reunion> listaReuniones = new List<Reunion>();//lista de reuniones
        private Profesor tutor;
        private int facultad;// 0 = FCI , 1 = EEGCC
        public int Facultdad
        {
            get { return facultad; }
        }
        public List<Reunion> listaReunion
        {
            get { return this.listaReuniones; }
        }
        public Profesor Tutor1
        {
            get { return tutor; }
            set { tutor = value; }
        }

        public Profesor Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public Alumno(int cod, string nom, int dn, string corr, int telf,int cic,int cred,int facultad)
            : base(cod,nom,dn,corr,telf)
        {
            ciclo = cic;
            creditos = cred;
            this.facultad = facultad;
        }
        public Alumno()
            : base()
        {
            ciclo = 0;
            creditos = 0;
        }
        public override string formatearMostrar() {
            string nombreFacultdad= "";
            switch(this.facultad)
            {
                case 0:
                    nombreFacultdad = "(FCI)";
                        break;
                case 1:
                        nombreFacultdad = "(EEGGCC)";
                    break;
            }
            return Codigo + "--" + Nombre+" "+nombreFacultdad; 
        }
    }
}
