using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class Pedido
    {
        #region Variables Miembro
        int idPedido;
        double total;
        DateTime fecha;
        #endregion

        #region Propiedades
        public int IdPedido
        {
            get
            {
                return idPedido;
            }

            set
            {
                idPedido = value;
            }
        }

        public void Guardar()
        {
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            EPedido p = new EPedido();
            p.idPedido = this.idPedido;
            p.fecha = this.fecha;
            p.total = (decimal)this.total;
            dtc.EPedido.InsertOnSubmit(p);
            dtc.SubmitChanges();
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
        #endregion

        #region Bob
        public Pedido(double total, DateTime fecha)
        {
            this.Total = total;
            this.Fecha = fecha;
        }
        public Pedido(int idPedido, double total, DateTime fecha)
        {
            this.IdPedido = idPedido;
            this.Total = total;
            this.Fecha = fecha;
        }
        public Pedido()
        {
            this.IdPedido = 0;
            this.Total = 0;
            this.Fecha = DateTime.Today;
        }


        #endregion

        #region Meto2
        public static Pedido ObtenerPedido()
        {
            int mayor = 0;
                Pedido resultado = new Pedido();
                dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.EPedido
                       select x;
            foreach(EPedido x in cons)
            {
                if (x.idPedido > mayor)
                    mayor = x.idPedido;
                    
            }
            var cons2 = from x in dtc.EPedido
                        where x.idPedido==mayor
                       select x;
            foreach(EPedido x in cons2)
            {
                resultado = new Pedido(x.idPedido,(double)x.total,(DateTime)x.fecha);
            }
            return resultado;
        }

        public static double calcularTotal(double producto, double tamano)
        {

            return producto + tamano;
        }

        public static void BorrarPedido()
        {
                int idd = Pedido.ObtenerPedido().idPedido;
                dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
                var cons = from x1 in dtc.EPedido
                           where x1.idPedido == idd
                           select x1;

            var cons2 = from x2 in dtc.EDetalle
                        where x2.fkPedido == idd
                        select x2;

            dtc.EPedido.DeleteOnSubmit(cons.First());
            
            foreach (EDetalle x in cons2)
            { 
                dtc.EDetalle.DeleteOnSubmit(x);
            }
            dtc.SubmitChanges();
        }
        #endregion
    }
}
