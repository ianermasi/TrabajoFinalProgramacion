using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Pedido
    {
        #region Variables Miembro
        int idPedido;
        double total;
        DateTime fecha;
        #endregion

        #region Propiedades
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public double Total { get => total; set => total = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        #endregion

        #region Bob
        #endregion

        #region Constructor
        #endregion
    }
}
