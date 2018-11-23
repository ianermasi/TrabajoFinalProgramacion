using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.ComponentModel;

namespace CapaNegocio
{
    public class Detalle
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
        [DisplayName("Producto")]
        public Producto Productos
        {
            get { return Producto.BuscarPorId(FkProducto); }
        }
        public string Tamaño
        {
            get { return Tamano.BuscarPorId(FkTamano).Nombre; }
        }
        [Browsable(false)]
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

       [Browsable(false)]
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
        [DisplayName("Precio")]
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
        public Detalle(int fkPedido, int fkProducto, string observaciones, int fkTamano, double precio)
        {
            this.IdDetalle = 0;
            this.FkPedido = fkPedido;
            this.FkProducto = fkProducto;
            this.Observaciones1 = observaciones;
            this.FkTamano = fkTamano;
            this.Precio1 = precio;
        }
        public Detalle()
        {
            this.IdDetalle = 0;
            this.FkPedido = 0;
            this.FkProducto = 0;
            this.Observaciones1 = "";
            this.FkTamano = 0;
            this.Precio1 = 0;
        }
        #endregion

        #region Constructor
        public override string ToString()
        {
            return String.Concat(this.idDetalle + " - " + this.fkPedido + " - " + 
                this.fkProducto + " - " + this.Observaciones + " - " + this.fkTamano + " - " + this.Precio);
        }

        public void Guardar()
        {
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            EDetalle d = new EDetalle();
            d.idDetalle = 0;
            d.fkPedido = this.fkPedido;
            d.fkProducto = this.fkProducto;
            d.fkTamano = this.fkTamano;
            d.Observaciones = this.Observaciones;
            d.Precio = (decimal)this.Precio;
            dtc.EDetalle.InsertOnSubmit(d);
            dtc.SubmitChanges();
        }

        public static List<Detalle> ListaDetalles(int idpedido)
        {
                List<Detalle> aux = new List<Detalle>();
                dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
                var cons = from x in dtc.EDetalle
                           where x.fkPedido == idpedido
                           select x;
                foreach (EDetalle x in cons)
                {
                    aux.Add(new Detalle((int)x.fkPedido, (int)x.fkProducto,x.Observaciones, (int)x.fkTamano, (double)x.Precio));
                }
                return aux;
        }
        #endregion
    }
}
