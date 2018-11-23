using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class Producto
    {
        #region Variables Miembro
        int idProducto;
        string nombre;
        double precio;
        int fkTipo;
        #endregion

        #region Propiedades
        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
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

        public int FkTipo
        {
            get
            {
                return fkTipo;
            }

            set
            {
                fkTipo = value;
            }
        }
        #endregion

        #region Bob
        public Producto(int id, string nomb, double precio, int fktipo)
        {
            this.IdProducto = id;
            this.Nombre = nomb;
            this.Precio = precio;
            this.FkTipo = fktipo;

        }
        public Producto()
        {
            this.IdProducto = 0;
            this.Nombre = "";
            this.Precio = 0;
            this.FkTipo = 0;
        }
        #endregion

        #region Meto2
        public static Producto BuscarPorNombre(string buscado)
        {
            Producto resultado = new Producto();
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.EProducto
                       where x.nombre.Trim().ToLower().Equals(buscado.ToLower().Trim())
                       select x;
            foreach (EProducto x in cons)
            {
                resultado = new Producto(x.idProducto, x.nombre, (double)x.precio, (int)x.fkTipo);
            }
            return resultado;
        }
        public static TP BuscarTamaño(int fkTipo)
        {
            TP resultado = new TP();
            Tipo resultado2 = new Tipo();

            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from y in dtc.EPT
                       where y.ETipo.idTipo == fkTipo
                       select y;


            resultado = new TP(cons.First().idPT, (int)cons.First().fkTipo, (int)cons.First().fkTamano);
            return resultado;
        }
        #endregion
    }
}
