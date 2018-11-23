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
    public partial class FormPostres : Form
    {
        double totaal=0;
        public FormPostres()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void RBTNFrutilla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTNChocolate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTNDulce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LBLSalsa_Click(object sender, EventArgs e)
        {

        }

        private void CargarImagenes()
        {
            Cucuruchones.BackgroundImage = IMLPostres.Images[0];
            King_Mix.BackgroundImage = IMLPostres.Images[1];
            Cono.BackgroundImage = IMLPostres.Images[2];
            Cono_Relleno.BackgroundImage = IMLPostres.Images[3];
            Sundae.BackgroundImage = IMLPostres.Images[4];
        }

        private void Cucuruchones_MouseClick(object sender, MouseEventArgs e)
        {
            LBLNombre.Text = "";
            foreach (object x in PNLContenedor.Controls)
            {
                if (x is Panel)
                    (x as Panel).BackColor = Color.White;
            }
            (sender as Panel).BackColor = Color.LightBlue;
            string[] nombre = null;
            try
            {
                nombre = (sender as Panel).Name.Split('_');
            }
            catch { MessageBox.Show("hla"); }

            foreach (string x in nombre)
            {
                LBLNombre.Text = LBLNombre.Text + "" + x;
            }
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            string tam = "";
            foreach (object x in PNLOpciones.Controls)
            {
                if (x is RadioButton)
                    if ((x as RadioButton).Checked == true)
                    {
                        tam = (x as RadioButton).Name;
                    }
            }
            if (tam != "")
            {
                foreach (object x in PNLContenedor.Controls)
                {
                    if (x is Panel)
                    {
                        if ((x as Panel).BackColor != Color.White)
                        {
                            Detalle a = new Detalle();
                            a = new Detalle(Pedido.ObtenerPedido().IdPedido, Producto.BuscarPorNombre((x as Panel).Name).IdProducto, FormPrincipal.ObtenerObservaciones(), Tamano.BuscarPorNombre(tam).IdTamano, Pedido.calcularTotal(Producto.BuscarPorNombre((x as Panel).Name).Precio, Tamano.BuscarPorNombre(tam).Precio));
                            a.Guardar();
                            totaal = a.Precio1;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Eleji un tamaño >:c");
            }
        }

    }
}
