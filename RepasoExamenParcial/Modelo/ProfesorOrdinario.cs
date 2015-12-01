using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    class ProfesorOrdinario : Profesor
    {
        private string fechaIngreso;
        private string fechaRevalidacion;
        private string fechaFinCategoria;
        private string categoria;


        public override string formatearMostrar() {
            return ""; 
        }
        public ProfesorOrdinario(int cod,string nom,int dn,string corr,int telf,string reg,int idio,int anho,string grad,Especialidad esp,
            string fIn,string fRe,string fFin,string categ):base(cod,nom,dn,corr,telf,reg,idio,anho,grad,esp) {
            fechaIngreso = fIn;
            fechaRevalidacion = fRe;
            fechaFinCategoria = fFin;
            categoria = categ;
        }
        public ProfesorOrdinario(): base()
        {
            fechaIngreso = "";
            fechaRevalidacion = "";
            fechaFinCategoria = "";
            categoria = "";
        }

    }

   
}
