using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class TP
    {
        int idPT;
        int fkTipo;
        int fkTamano;

        public int IdPT
        {
            get
            {
                return idPT;
            }

            set
            {
                idPT = value;
            }
        }

        public int FkTipo
        {
            get
            {
                return fkTipo;
            }

            set
            {
                fkTipo = value;
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

        public TP(int idPT, int fkTipo, int fkTamano)
        {
            this.IdPT = idPT;
            this.FkTipo = fkTipo;
            this.FkTamano = fkTamano;
        }
        public TP()
        {
            this.IdPT = 0;
            this.FkTipo = 0;
            this.FkTamano = 0;
        }

      




        public static Tamano BuscarTamaño(int idTamaño)
        {
            Tamano resultado = new Tamano();
            dataDataContext dtc = new dataDataContext(Conexion.DarStringConexion());
            var cons = from x in dtc.EPT
                       where x.fkTamano == idTamaño
                       select x.ETamano;
            foreach (ETamano x in cons)
            {
                resultado = new Tamano(x.idTamano, x.nombre, (double)x.precio);
            }
            return resultado;
        }
    }
}
