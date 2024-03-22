using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace ClothCraze.Modales.ModalLogin
{
    public partial class Create : UserControl
    {
        public Create()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY= true");

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                PtbImagen.Image = Image.FromFile(dialogo.FileName);
                PtbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }

            BtnAgregarPtb.Visible = false;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                PtbImagen.Image = Image.FromFile(dialogo.FileName);
                PtbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        string TipoUsuario = "Administrador";

        private void BtnnCrear_Click(object sender, EventArgs e)
        {
           

            cnxn.Open();

            string consulta = "INSERT INTO Login (Nombre, Correo, Contraseña, Foto, TipoUsuario) " +
                "values (@vNombre, @vCorreo, @vContraseña, @vFoto, @vTipoUsuario)";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            MemoryStream memoria = new MemoryStream();
      

            PtbImagen.Image.Save(memoria, ImageFormat.Bmp);

            cmd.Parameters.AddWithValue("@vNombre", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@vCorreo", TxtCorreo.Text);
            cmd.Parameters.AddWithValue("@vContraseña", TxtContraseña.Text);
            cmd.Parameters.AddWithValue("@vFoto", memoria.GetBuffer());
            cmd.Parameters.AddWithValue("@vTipoUsuario", TipoUsuario);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Cuenta Agregada");

            cnxn.Close();

        }

        private void Create_Load(object sender, EventArgs e)
        {
  
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!TxtCorreo.Text.Contains("@ClothCraze.com"))
            {
                TxtCorreo.Text = "@ClothCraze.com";
                TxtCorreo.SelectionStart = 0;
            }

      
        }
    }
}
