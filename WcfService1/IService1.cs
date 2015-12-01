using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Usuario buscarUsuario(string usuario);

        [OperationContract]
        int crearUsuario(Usuario newUsuario);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class Usuario
    {
        public string user;
        public string pass;
        public int tipo; // 0 = General , 1=  Admin EEGGCC , 2 = AdminFCI

        [DataMember]
        public string UserName
        {

            get { return this.user; }
            set { this.user = value; }

        }

        [DataMember]
        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        [DataMember]
        public int Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
    }
}
