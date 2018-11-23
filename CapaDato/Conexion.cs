using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class Conexion
    {
        private static string server = @"172.16.5.30";
        private static string db = @"ProgramacionFinal";
        private static string usuario = @"Nanu";
        private static string clave = @"123456";

        public static string DarStringConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db, ";Persist Security Info=false;User ID=", usuario, ";Password=", clave);
        }
    }
}
