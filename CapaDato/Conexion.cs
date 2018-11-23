using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class Conexion
    {
        private static string server = @"192.168.1.103";
        private static string db = @"ProgramacionFinal";
        private static string usuario = @"sa";
        private static string clave = @"123";

        public static string DarStringConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db, ";Persist Security Info=false;User ID=", usuario, ";Password=", clave);
        }
    }
}
