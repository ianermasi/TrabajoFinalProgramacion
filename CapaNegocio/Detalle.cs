using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Detalle
    {
        #region Variables Miembro
        int idDetalle;
        int fkPedido;
        int fkProducto;
        string Observaciones;
        int fkTamano;
        double Precio;
        #endregion

        #region Propiedades
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int FkPedido { get => fkPedido; set => fkPedido = value; }
        public int FkProducto { get => fkProducto; set => fkProducto = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public int FkTamano { get => fkTamano; set => fkTamano = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        #endregion

        #region Bob
        #endregion

        #region Constructor
        public Detalle(int idDetalle, int fkPedido, int fkProducto, string observaciones, int fkTamano, double precio)
        {
            this.idDetalle = idDetalle;
            this.fkPedido = fkPedido;
            this.fkProducto = fkProducto;
            this.Observaciones = observaciones;
            this.fkTamano = fkTamano;
            this.Precio = precio;
        }
        #endregion
    }
}
