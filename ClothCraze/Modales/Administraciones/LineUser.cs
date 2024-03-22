using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.Administraciones
{
    public partial class LineUser : UserControl
    {
        public LineUser()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public string Nombre
        {
            get
            {
                return LblNombre.Text;
            }
            set
            {
                LblNombre.Text = value;
            }
        }

        public string Correo
        {
            get
            {
                return LblCorreo.Text;
            }
            set
            {
                LblCorreo.Text = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return LblContraseña.Text;
            }
            set
            {
                LblContraseña.Text = value;
            }
        }

        public Image Foto
        {
            get
            {
                return PtbFoto.Image;
            }
            set
            {
               PtbFoto.Image = value;
            }
        }

        public string TipoUsuario
        {
            get
            {
                return LblTipoUsuario.Text;
            }
            set
            {
                LblTipoUsuario.Text = value;
            }
        }

        public string ID
        {
            get
            {
                return BtnEliminar.Name;
            }
            set
            {
                BtnEliminar.Name = value;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string ID = BtnEliminar.Name;
            int ValorID = int.Parse(ID);

            cnxn.Open();

            string consulta = "DELETE FROM Login WHERE Id = "+ ValorID +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
