using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class FormReporteTicket : Form
    {
        public FormReporteTicket()
        {
            InitializeComponent();
        }

        private void FormReporteTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSTicket.DTTicket' table. You can move, or remove it, as needed.
            //this.DTTicketTableAdapter.Fill(this.DSTicket.DTTicket);

            //this.RVTicket.RefreshReport();
            CargarReporte();
        }

        private void CargarReporte()
        {
            DTTicketTableAdapter.Connection.ConnectionString = Conexion.DarStringConexion();
            this.DTTicketTableAdapter.Fill(this.DSTicket.DTTicket);
            this.RVTicket.RefreshReport();
        }
    }
}
