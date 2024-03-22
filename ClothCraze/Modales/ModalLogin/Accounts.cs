using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.ModalLogin
{
    public partial class Accounts : UserControl
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(bunifuShadowPanel1);
            guna2Transition1.ShowSync(Sesion);
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            guna2Transition2.HideSync(bunifuShadowPanel1);
            guna2Transition1.ShowSync(Create);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
