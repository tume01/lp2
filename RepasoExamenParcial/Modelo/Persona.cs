using Vista;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable]
    public abstract class Persona: IMostrable
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
        private int dni;
        private string correo;
        private int telefono;
        public int Telefono
        {
            get { return telefono; }
        }
        public int DNI
        {
            get { return dni;}
           
        }

        public string Correo
        {
            get { return correo; }
        }
        public Persona(int cod,string nom,int dn,string corr,int telf) {
            codigo = cod;
            nombre = nom;
            dni = dn;
            correo = corr;
            telefono = telf;
        }
        public abstract string formatearMostrar() ;
        public Persona()
        {
            codigo = 0;
            nombre = "";
            dni = 0;
            correo = "";
            telefono = 0;
        }
    }
}
