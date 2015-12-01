using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        List<Usuario> usuarios = new List<Usuario>();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int crearUsuario(Usuario newUsuario)
        {
            if (newUsuario == null)
            {
                throw new ArgumentNullException("composite");
            }

            usuarios.Add(newUsuario);

            FileStream Output = new FileStream("C:\\temp\\users.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter Formateador = new BinaryFormatter();
            Formateador.Serialize(Output, usuarios);
            Output.Close();

            return usuarios.Count();
        }

        public Usuario buscarUsuario(string username)
        {
            foreach (Usuario u in usuarios)
            {
                if (username == u.UserName)
                {
                    return u;
                }
            }

            return null;
        }
 
        public Service1()
        {
            FileStream Input = new FileStream("C:\\temp\\users.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter Formateador = new BinaryFormatter();

            try
            {
                usuarios = (List<Usuario>)Formateador.Deserialize(Input);
            }
            catch (SerializationException e)
            {
                System.Console.WriteLine(e.Message);
            }
            Input.Close();
        }
    }
}
