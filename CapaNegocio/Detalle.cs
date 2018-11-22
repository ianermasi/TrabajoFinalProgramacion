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
        public int IdDetalle
        {
            get
            {
                return idDetalle;
            }

            set
            {
                idDetalle = value;
            }
        }

        public int FkPedido
        {
            get
            {
                return fkPedido;
            }

            set
            {
                fkPedido = value;
            }
        }

        public int FkProducto
        {
            get
            {
                return fkProducto;
            }

            set
            {
                fkProducto = value;
            }
        }

        public string Observaciones1
        {
            get
            {
                return Observaciones;
            }

            set
            {
                Observaciones = value;
            }
        }

        public int FkTamano
        {
            get
            {
                return fkTamano;
            }

            set
            {
                fkTamano = value;
            }
        }

        public double Precio1
        {
            get
            {
                return Precio;
            }

            set
            {
                Precio = value;
            }
        }
        #endregion

        #region Bob
        #endregion

        #region Constructor
        public Detalle(int idDetalle, int fkPedido, int fkProducto, string observaciones, int fkTamano, double precio)
        {
            this.IdDetalle = idDetalle;
            this.FkPedido = fkPedido;
            this.FkProducto = fkProducto;
            this.Observaciones1 = observaciones;
            this.FkTamano = fkTamano;
            this.Precio1 = precio;
        }
        #endregion
    }
}
