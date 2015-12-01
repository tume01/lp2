using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public class Especialidad
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Especialidad() {
            codigo = 0;
            nombre = "";
        }
        public Especialidad(int cod,string nom)
        {
            codigo = cod;
            nombre = nom;
        }
    }

    
}
