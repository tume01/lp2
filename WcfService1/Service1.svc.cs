using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Factories;
using WcfService1.Persistances;
using WcfService1.Repositories;

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
            UsuarioRepository.insert(newUsuario);
           

            return usuarios.Count();
        }

        public Usuario buscarUsuario(string username)
        {
            Usuario selectedUser  = UserPersistance.getUserById(username);

            return selectedUser;
        }
 
        public Service1()
        {
           
        }
    }
}
