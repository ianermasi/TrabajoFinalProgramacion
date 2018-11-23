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
    public partial class FormBebidas : Form
    {
        public double totaal;
        public FormBebidas()
        {
            InitializeComponent();
            CargarImagenes();
        }
        private void CargarImagenes()
        {
            Aquarius.BackgroundImage = IMLBebidas.Images[0];
            Coca_Cola.BackgroundImage = IMLBebidas.Images[1];
            Coca_Cola_Light.BackgroundImage = IMLBebidas.Images[2];
            Fanta.BackgroundImage = IMLBebidas.Images[3];
            Sprite.BackgroundImage = IMLBebidas.Images[4];
            Sprite_Light.BackgroundImage = IMLBebidas.Images[5];
        }

        private void Aquarius_MouseClick(object sender, MouseEventArgs e)
        {
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
               // LBLNombre.Text = LBLNombre.Text + "" + x;
            }
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            string tam="";
            foreach(object x in PNLOpciones.Controls)
            {
                if(x is RadioButton)
                if((x as RadioButton).Checked == true)
                {
                    tam = (x as RadioButton).Name;
                }
            }
            if(tam != "")
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
