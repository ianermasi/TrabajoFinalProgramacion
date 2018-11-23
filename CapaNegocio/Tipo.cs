using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class Tipo
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
        public Tipo(int idTipo, string nombre)
        {
            this.IdTipo = idTipo;
            this.Nombre = nombre;
        }
        public Tipo()
        {
            this.IdTipo = 0;
            this.Nombre = "";
        }
        #endregion

        #region Constructor
        public static Tipo BuscarPorId(int buscado)
        {
            Tipo resultado = new Tipo();
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.ETipo
                       where x.idTipo.Equals(buscado)
                       select x;
            foreach (ETipo x in cons)
            {
                resultado = new Tipo(x.idTipo, x.nombre);
            }
            return resultado;
        }
        #endregion

    }
}
