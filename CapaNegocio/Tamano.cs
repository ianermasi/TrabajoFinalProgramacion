using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Tamano
    {
        #region Variables Miembro
        int idTamano;
        string nombre;
        double precio;


        #endregion

        #region Propiedades
        public int IdTamano
        {
            get
            {
                return idTamano;
            }

            set
            {
                idTamano = value;
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
        #endregion

        #region Bob
        #endregion

        #region Constructor
        public Tamano(int idTamano, string nombre, double precio)
        {
            this.IdTamano = idTamano;
            this.Nombre = nombre;
            this.Precio = precio;
        }

       
        #endregion

    }
}
