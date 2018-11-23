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
    public partial class FormPrincipal : Form
    {
        public static string observ = "";
        public static double total = 0;
        public FormPrincipal()
        {
            InitializeComponent();
            PNLCuotas.Visible = false;
            PNLEfectivo.Visible = false;
            Pedido p = new Pedido(0,DateTime.Today);
            p.Guardar();
            
        }

        private void PBXCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBXMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormulario(object formhijo)
        {
            if (this.PNLForms.Controls.Count > 0)
                this.PNLForms.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PNLForms.Controls.Add(fh);
            this.PNLForms.Tag = fh;
            fh.Show();
        }

        private void BTNCombos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCombos());
        }

        private void BTNBebidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormBebidas());
        }

        private void BTNHamburguesas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormHamburguesas());
        }

        private void BTNExtras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormExtras());
        }

        private void BTNPostres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPostres());
        }

        private void RBTNTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if(RBTNTarjeta.Checked)
            {
                PNLCuotas.Visible = true;
                PNLEfectivo.Visible = false;
            }  
        }

        private void RBTNEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTNEfectivo.Checked)
            {
                PNLCuotas.Visible = false;
                PNLEfectivo.Visible = true;
            }
        }

        public static void ModificarTotal(double c)
        {
            total = c;
        }

        private void PNLOcultar_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string ObtenerObservaciones()
        {
            return observ;
        }

        private void TXTObservaciones_Leave(object sender, EventArgs e)
        {
            observ = TXTObservaciones.Text;
        }
    }
}
