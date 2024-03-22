using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.Plus
{
    public partial class Deslizador : UserControl
    {
        public Deslizador()
        {
            InitializeComponent();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Clases.Administracion.Deslizar = true;

            BtnVer.Visible = false;
            BtnNoVer.Visible = true;

        }

        private void BtnNoVer_Click(object sender, EventArgs e)
        {
            Clases.Administracion.Deslizar = false;

            BtnNoVer.Visible = false;
            BtnVer.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(BtnVer.Visible == true)
            {
                Clases.Administracion.Deslizar = true;

                BtnVer.Visible = false;
                BtnNoVer.Visible = true;
  
            }
            else
            {
                Clases.Administracion.Deslizar = false;

                BtnNoVer.Visible = false;
                BtnVer.Visible = true;

            }
        }
    }
}
