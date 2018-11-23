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
    public partial class FormCombos : Form
    {
        public static double totaal = 0;
        public FormCombos()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            Long_Classic.BackgroundImage = IMLCombo.Images[0];
            Atomic.BackgroundImage = IMLCombo.Images[1];
            Big_King.BackgroundImage = IMLCombo.Images[2];
            Big_King_Pollo.BackgroundImage = IMLCombo.Images[3];
            Soja_Bio.BackgroundImage = IMLCombo.Images[4];
            Stacker_Cuadruple.BackgroundImage = IMLCombo.Images[5];
            Stacker_Triple.BackgroundImage = IMLCombo.Images[6];
            Caja_King.BackgroundImage = IMLCombo.Images[7];
            Churrasquito_Pampeano.BackgroundImage = IMLCombo.Images[8];
            Churrasquito_Tradicional.BackgroundImage = IMLCombo.Images[9];
            Hamburguesa_Queso.BackgroundImage = IMLCombo.Images[10];
            Hamburguesa_Simple.BackgroundImage = IMLCombo.Images[11];
            King_Pollo.BackgroundImage = IMLCombo.Images[12];
            King_Pollo_Frances.BackgroundImage = IMLCombo.Images[13];
            Napolitano.BackgroundImage = IMLCombo.Images[14];
            WhopperJr.BackgroundImage = IMLCombo.Images[15];
            Long_Clasico.BackgroundImage = IMLCombo.Images[16];
            Extra_Burguer.BackgroundImage = IMLCombo.Images[17];
            Atomic_Frances.BackgroundImage = IMLCombo.Images[18];
            Long_Queso.BackgroundImage = IMLCombo.Images[19];
            Long_Rodeo.BackgroundImage = IMLCombo.Images[20];
            Whopper.BackgroundImage = IMLCombo.Images[21];
            Whopper_Extreme.BackgroundImage = IMLCombo.Images[22];
        }

        private void PNLImagen1_MouseClick(object sender, MouseEventArgs e)
        {
            LBLNombre.Text = "";
            foreach (object x in PNLProductosCombos.Controls)
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
            string bebida = "";
            string papas = "";
            foreach (object x in PNLOpciones.Controls)
            {
                if (x is RadioButton)
                    if ((x as RadioButton).Checked == true)
                    {
                        tam = (x as RadioButton).Name;
                    }
            }
            foreach (object x in PNLOpciones3.Controls)
            {
                if (x is RadioButton)
                    if ((x as RadioButton).Checked == true)
                    {
                        papas = (x as RadioButton).Name;
                    }
            }
            foreach (object x in PNLOpciones2.Controls)
            {
                if (x is RadioButton)
                    if ((x as RadioButton).Checked == true)
                    {
                        bebida = (x as RadioButton).Name;
                    }
            }
            if (tam != "" && papas != "" && bebida!="")
            {
                foreach (object x in PNLProductosCombos.Controls)
                {
                    if (x is Panel)
                    {
                        if ((x as Panel).BackColor != Color.White)
                        {
                            Detalle a = new Detalle();
                            a = new Detalle(Pedido.ObtenerPedido().IdPedido, Producto.BuscarPorNombre((x as Panel).Name).IdProducto, FormPrincipal.ObtenerObservaciones(), Tamano.BuscarPorNombre(tam).IdTamano, Pedido.calcularTotal(Producto.BuscarPorNombre((x as Panel).Name).Precio, Tamano.BuscarPorNombre(tam).Precio));
                            a.Guardar();
                            totaal += a.Precio1;

                            Detalle b = new Detalle();
                            b = new Detalle(Pedido.ObtenerPedido().IdPedido, Producto.BuscarPorNombre(bebida).IdProducto, FormPrincipal.ObtenerObservaciones(), Tamano.BuscarPorNombre(tam).IdTamano, Pedido.calcularTotal(Producto.BuscarPorNombre(papas).Precio, Tamano.BuscarPorNombre(tam).Precio));
                            b.Guardar();
                            totaal += b.Precio1;

                            Detalle c = new Detalle();
                            c = new Detalle(Pedido.ObtenerPedido().IdPedido, Producto.BuscarPorNombre(papas).IdProducto, FormPrincipal.ObtenerObservaciones(), Tamano.BuscarPorNombre(tam).IdTamano, Pedido.calcularTotal(Producto.BuscarPorNombre(bebida).Precio, Tamano.BuscarPorNombre(tam).Precio));
                            c.Guardar();
                            totaal += c.Precio1;

                            Program.a.ActualizarDGV();
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
