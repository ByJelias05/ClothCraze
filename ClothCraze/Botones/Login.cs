using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Botones
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }


        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if(BtnLogin.Text == "LOG IN")
            {
                Form Sombra = new Form();

                using (Modales.Modal Modal = new Modales.Modal())
                {
                    Sombra.StartPosition = FormStartPosition.CenterScreen;
                    Sombra.FormBorderStyle = FormBorderStyle.None;
                    Sombra.Size = Clases.Tamaños.size;
                    Sombra.Opacity = .50;
                    Sombra.BackColor = Color.Black;
                    Sombra.ShowInTaskbar = false;
                    Sombra.Show();


                    Modal.ShowDialog();
                    Sombra.Dispose();

                    
                }
                
            }
            else
            {
                guna2MessageDialog1.Show();
                
            }

            Clases.EstadoSeccion.Respuesta = "NoMostrar";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Clases.EstadoSeccion.Nombre != null)
            {
                BtnLogin.Text = Clases.EstadoSeccion.Nombre;
                BtnLogin.Image = Clases.EstadoSeccion.Foto;

                


            }

            if(BtnLogin.Text == "LOG IN")
            {
                Clases.EstadoSeccion.Estado = "NoLog";
            }
            else
            {
                Clases.EstadoSeccion.Estado = "SiLog";

            }

            guna2ColorTransition1.StartColor = Color.Red;

            if (Clases.EstadoSeccion.Respuesta == "Mostrar" && BtnLogin.Text == "LOG IN")
            {


                BtnLogin.FillColor = Color.Red;

            }
            else
            {
                BtnLogin.FillColor = Color.White;
            }
        }

      
    }
}
