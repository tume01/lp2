using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class EspecialidadRepository
    {
        public static string connecString = ConfigDB.configDB.connectString();

        public EspecialidadRepository()
        {

        }
    }
}