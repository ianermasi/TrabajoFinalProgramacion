using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Tipo
    {
        #region Variables Miembro
        int idTipo;
        string nombre;

       
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        #endregion

        #region Bob
        #endregion

        #region Constructor
        public Tipo(int idTipo, string nombre)
        {
            this.idTipo = idTipo;
            this.nombre = nombre;
        }
        #endregion

    }
}
