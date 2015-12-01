using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
     [Serializable]
    public class AlumnoFCI: Alumno
    {
        private string resumenReuniones;

        public string Resumen
        {
            get { return resumenReuniones; }
        }
        public AlumnoFCI(string resumen,int cod, string nom, int dn, string corr, int telf, int cic, int cred,int facultdad)
            : base(cod, nom, dn, corr, telf, cic, cred, facultdad)
        {
            this.resumenReuniones = resumen;
        }


    }
}
