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
    public partial class FormBebidas : Form
    {
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
        }
    }
}
