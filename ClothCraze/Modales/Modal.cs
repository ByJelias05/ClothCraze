using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;



using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;


namespace ClothCraze.Modales
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
            
        }

        private void Modal_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Visible == true) 
            {
                MessageBox.Show("Se ve");
            }
            else
            {
                MessageBox.Show("No se ve");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Clases.EstadoSeccion.TipoUsuario == "Administrador")
            {
                   this.Hide();
                ShowInTaskbar = false;
               
             
            }

            
        }

        private void Modal_Load_1(object sender, EventArgs e)
        {

          
        }
    }
}
