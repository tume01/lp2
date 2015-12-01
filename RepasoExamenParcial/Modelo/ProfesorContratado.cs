using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    class ProfesorContratado : Profesor
    {
        private string fechaInicio;
        private string fechaFin;
        public string Inicio
        {
            get { return fechaInicio; }
        }

        public string Fin
        {
            get { return fechaFin; }
        }
        public override string formatearMostrar() { 
            return ""; 
        }
        public ProfesorContratado(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Especialidad esp,
            string fIn,string fFin):base(cod,nom,dn,corr,telf,reg,idio,anho,grad,esp) {
            fechaInicio = fIn;
            fechaFin = fFin;
        }

    }
}
