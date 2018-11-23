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
        Pedido p;
        public FormPrincipal()
        {
            InitializeComponent();
            PNLCuotas.Visible = false;
            PNLEfectivo.Visible = false;
           p = new Pedido(0,DateTime.Today);
            p.Guardar();
            ActualizarDGV();

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

            FormBebidas a = new FormBebidas();
            AbrirFormulario(a);
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

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            PNLEfectivo.Visible = false;
            PNLCuotas.Visible = false;
            RBTNEfectivo.Checked = false;
            RBTNTarjeta.Checked = false;
            NUDRecibido.Value = 0;
            RBTNUnPago.Checked = false;
            RBTN3Cuotas.Checked = false;
            RBTN6Cuotas.Checked = false;
            RBTN12Cuotas.Checked = false;
            TXTObservaciones.Text = "";
            DGVPedido.DataSource = null;
            Pedido.BorrarPedido();
        }

        public void ActualizarDGV()
        {
            DGVPedido.DataSource = null;
            DGVPedido.DataSource = Detalle.ListaDetalles(Pedido.ObtenerPedido().IdPedido).ToList();
            this.DGVPedido.Columns["Precio1"].DefaultCellStyle.Format = "$0";
            this.DGVPedido.Columns["Observaciones1"].HeaderText = "Observaciones";
            this.DGVPedido.Columns["FkPedido"].Visible = false;
            this.DGVPedido.Columns["FkTamano"].Visible = false;

            LBLTotal.Text = (FormBebidas.totaal + FormExtras.totaal + FormHamburguesas.totaal + FormPostres.totaal + FormCombos.totaal).ToString(); ;
        }

        private void NUDRecibido_Leave(object sender, EventArgs e)
        {
            double resultado=0;
            try
            {
                resultado = (double)NUDRecibido.Value - Int32.Parse(LBLTotal.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (resultado >= 0)
            {
                LBLDevolverNumero.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("faltan $" + resultado.ToString().Split('-')[1]);
            }
        }

        private void BTNFinalizar_Click(object sender, EventArgs e)
        {
            /*Pedido a = new Pedido(0, DateTime.Today);
            a.Guardar();*/
            //FormReporteTicket frt = new FormReporteTicket();
            frt.Show();
            ActualizarDGV();
            PNLEfectivo.Visible = false;
            PNLCuotas.Visible = false;
            RBTNEfectivo.Checked = false;
            RBTNTarjeta.Checked = false;
            NUDRecibido.Value = 0;
            RBTNUnPago.Checked = false;
            RBTN3Cuotas.Checked = false;
            RBTN6Cuotas.Checked = false;
            RBTN12Cuotas.Checked = false;
            TXTObservaciones.Text = "";
            DGVPedido.DataSource = null;
            LBLTotal.Text = "000";
            LBLDevolverNumero.Text = "000";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
