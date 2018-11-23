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

        public TP(int idPT, int fkTipo, int fkTamano)
        {
            this.idPT = idPT;
            this.fkTipo = fkTipo;
            this.fkTamano = fkTamano;
        }
        public TP()
        {
            this.idPT = 0;
            this.fkTipo = 0;
            this.fkTamano = 0;
        }

        public int IdPT { get => idPT; set => idPT = value; }
        public int FkTipo { get => fkTipo; set => fkTipo = value; }
        public int FkTamano { get => fkTamano; set => fkTamano = value; }




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
