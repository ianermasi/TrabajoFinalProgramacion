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
    public partial class FormExtras : Form
    {
        public FormExtras()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void Aros_Cebolla_MouseClick(object sender, MouseEventArgs e)
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
                LBLNombre.Text = LBLNombre.Text + "" + x;
            }
        }
        private void CargarImagenes()
        {
            Aros_Cebolla.BackgroundImage = IMLExtras.Images[0];
            Ensalada_Caesar.BackgroundImage = IMLExtras.Images[1];
            Ensalada_Gourmet.BackgroundImage = IMLExtras.Images[2];
            Nuggets.BackgroundImage = IMLExtras.Images[3];
            Snack.BackgroundImage = IMLExtras.Images[4];
            Papas_Fritas.BackgroundImage = IMLExtras.Images[5];
            Tomatitos.BackgroundImage = IMLExtras.Images[6];
            Papas_Con_Cheddar.BackgroundImage = IMLExtras.Images[7];
        }
        }
}
