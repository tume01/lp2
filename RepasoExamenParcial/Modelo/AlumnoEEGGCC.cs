using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
     [Serializable]
    public class AlumnoEEGGCC: Alumno
    {
        private Especialidad especialidadActual;
        private Especialidad especialidadAnterior;

        public Especialidad EspecialidadActual
        {
            get { return especialidadActual; }
        }
        public Especialidad EspecialidadAnterior
        {
            get { return especialidadAnterior; }
            
        }
        public void setEspecialidadActual(Especialidad actual)
        {
            this.especialidadActual = actual;
        }

        public void setEspecialidadAnterior(Especialidad anterior)
        {
            this.especialidadAnterior = anterior;
        }

        public AlumnoEEGGCC(Especialidad anteior, Especialidad actual, int cod, string nom, int dn, string corr, int telf, int cic, int cred, int facultdad)
            : base(cod, nom, dn, corr, telf, cic, cred, facultdad)
        {
            this.especialidadAnterior = anteior;
            this.especialidadActual = actual;
        }
    }
}
