using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class FormCombos : Form
    {
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
            
            foreach(object x in PNLProductosCombos.Controls)
            {
                if(x is Panel)
                (x as Panel).BackColor = Color.White;
            }
            (sender as Panel).BackColor = Color.LightBlue;
            LBLNombre.Text = (sender as Panel).Name;
        }
    }
}
