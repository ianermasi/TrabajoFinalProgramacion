using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class Tamano
    {
        #region Variables Miembro
        int idTamano;
        string nombre;
        double precio;


        #endregion

        #region Propiedades
        public int IdTamano
        {
            get
            {
                return idTamano;
            }

            set
            {
                idTamano = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        internal static Tamano BuscarPorId(int fkTamano)
        {
            Tamano resultado = new Tamano();
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.ETamano
                       where x.idTamano == fkTamano
                       select x;
            foreach (ETamano x in cons)
            {
                resultado = new Tamano(x.idTamano, x.nombre, (double)x.precio);
            }
            return resultado;
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
        #endregion

        #region Bob
        public Tamano(int idTamano, string nombre, double precio)
        {
            this.IdTamano = idTamano;
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public Tamano()
        {
            this.IdTamano = 0;
            this.Nombre = "";
            this.Precio = 0;
        }
        #endregion

        #region Meto2

        public static Tamano BuscarPorNombre(string buscado)
        {
            Tamano resultado = new Tamano();
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.ETamano
                       where x.nombre.Trim().ToLower().Equals(buscado.ToLower().Trim())
                       select x;
            foreach (ETamano x in cons)
            {
                resultado = new Tamano(x.idTamano, x.nombre, (double)x.precio);
            }
            return resultado;
        }

        #endregion

    }
}
