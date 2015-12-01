using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public abstract class Profesor : Persona
    {
        private string regimenDedicacion;   
        private int idioma;                 
        private int anosExp;         
        private string gradoAcademico;
        private Especialidad especialidad;
        public int Idioma
        {
            get { return idioma; }
        }

        public string Regimen
        {
            get { return regimenDedicacion; }
        }
        public override abstract string formatearMostrar();
        public Profesor(int cod,string nom,int dn,string corr,int telf,string reg,int idio,int anho,string grad,Especialidad esp):base(cod,nom,dn,corr,telf) {
            regimenDedicacion = reg;
            idioma = idio;
            anosExp = anho;
            gradoAcademico = grad;
            especialidad = esp;
        }
        public Profesor()
            : base()
        {
            regimenDedicacion = "";
            idioma = 0;
            anosExp = 0;
            gradoAcademico = "";
            especialidad = new Especialidad();
        }
    }
}
