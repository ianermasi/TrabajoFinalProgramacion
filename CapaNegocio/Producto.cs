using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Producto
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
        #endregion

        #region Constructor
        #endregion
    }
}
