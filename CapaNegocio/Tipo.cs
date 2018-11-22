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
        public int IdTipo
        {
            get
            {
                return idTipo;
            }

            set
            {
                idTipo = value;
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
        #endregion

        #region Bob
        #endregion

        #region Constructor
        public Tipo(int idTipo, string nombre)
        {
            this.IdTipo = idTipo;
            this.Nombre = nombre;
        }
        #endregion

    }
}
