using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WcfService1.ConfigDB
{
    public class configDB
    {
        public static string connectString()
        {

            string server = System.Configuration.ConfigurationManager.AppSettings["server"];
            string port = System.Configuration.ConfigurationManager.AppSettings["port"];
            string database = System.Configuration.ConfigurationManager.AppSettings["database"];
            string uid = System.Configuration.ConfigurationManager.AppSettings["uid"];
            string pass = System.Configuration.ConfigurationManager.AppSettings["pass"];
            string connectstring = "Server="+server+";Port="+port+";Database="+database+";Uid="+uid+";password="+pass+";";
            return connectstring;
        }
    }
}