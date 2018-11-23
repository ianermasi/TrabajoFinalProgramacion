using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public class Program 
    {
        public static FormPrincipal a;
        FormPrincipal b;
        public static void Main()
        {
             a = new FormPrincipal();
            Application.Run(a);
        }
    }
}
