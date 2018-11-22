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
        public int IdPproducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int FkTipo { get => fkTipo; set => fkTipo = value; }
        #endregion

        #region Bob
        public Producto(int id, string nomb, double precio, int fktipo)
        {
            this.idProducto = id;
            this.nombre = nomb;
            this.precio = precio;
            this.fkTipo = fktipo;
        }
        #endregion

        #region Constructor
        #endregion
    }
}
