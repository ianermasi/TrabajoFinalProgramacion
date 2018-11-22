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
    public partial class FormHamburguesas : Form
    {
        public FormHamburguesas()
        {
            InitializeComponent();
            CargarImagenes();
        }
        private void CargarImagenes()
        {
            Long_Classic.BackgroundImage = IMLHamburguesa.Images[0];
            Atomic.BackgroundImage = IMLHamburguesa.Images[1];
            Big_King.BackgroundImage = IMLHamburguesa.Images[2];
            Big_King_Pollo.BackgroundImage = IMLHamburguesa.Images[3];
            Soja_Bio.BackgroundImage = IMLHamburguesa.Images[4];
            Stacker_Cuadruple.BackgroundImage = IMLHamburguesa.Images[5];
            Stacker_Triple.BackgroundImage = IMLHamburguesa.Images[6];
            Caja_King.BackgroundImage = IMLHamburguesa.Images[7];
            Churrasquito_Pampeano.BackgroundImage = IMLHamburguesa.Images[8];
            Churrasquito_Tradicional.BackgroundImage = IMLHamburguesa.Images[9];
            Hamburguesa_Queso.BackgroundImage = IMLHamburguesa.Images[10];
            Hamburguesa_Simple.BackgroundImage = IMLHamburguesa.Images[11];
            King_Pollo.BackgroundImage = IMLHamburguesa.Images[12];
            King_Pollo_Frances.BackgroundImage = IMLHamburguesa.Images[13];
            Napolitano.BackgroundImage = IMLHamburguesa.Images[14];
            WhopperJr.BackgroundImage = IMLHamburguesa.Images[15];
            Long_Clasico.BackgroundImage = IMLHamburguesa.Images[16];
            Extra_Burguer.BackgroundImage = IMLHamburguesa.Images[17];
            Atomic_Frances.BackgroundImage = IMLHamburguesa.Images[18];
            Long_Queso.BackgroundImage = IMLHamburguesa.Images[19];
            Long_Rodeo.BackgroundImage = IMLHamburguesa.Images[20];
            Whopper.BackgroundImage = IMLHamburguesa.Images[21];
            Whopper_Extreme.BackgroundImage = IMLHamburguesa.Images[22];
        }

        private void Long_Classic_MouseClick(object sender, MouseEventArgs e)
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
    }
}
