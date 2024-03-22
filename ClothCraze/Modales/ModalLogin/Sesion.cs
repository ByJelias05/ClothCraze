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
    public partial class Sesion : UserControl
    {
        public Sesion()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY= true");

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT Nombre, Correo, Contraseña, Foto, TipoUsuario FROM Login WHERE Correo= '"+ TxtCorreo.Text +"' AND Contraseña='"+ TxtContraseña.Text +"'";
            

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);


            SqlDataReader lector = cmd.ExecuteReader();

            if(lector.Read())
            {

                Byte[] archivo = (byte[])dt.Rows[0][3];
                Stream stream = new MemoryStream(archivo);

                Image imagen = Image.FromStream(stream);

                Clases.EstadoSeccion.Nombre = dt.Rows[0][0].ToString();
                Clases.EstadoSeccion.Correo = dt.Rows[0][1].ToString();
                Clases.EstadoSeccion.Contraseña = dt.Rows[0][2].ToString();
                Clases.EstadoSeccion.Foto = imagen;
                Clases.EstadoSeccion.TipoUsuario = dt.Rows[0][4].ToString();

                if (dt.Rows[0][4].ToString() == "Administrador")
                {
                    Administracion administracion = new Administracion();
                    administracion.ShowDialog();
                    this.Dispose();
                }

                Clases.EstadoSeccion.InicioSesion = true;
                LblEstado.Text = "¡You have logged in successfully!";

                Clases.Prodcutos.ConfirmacionMuestraCarrito = true;
                Clases.Prodcutos.ConfirmacionMuestraFavorito = true;


            }
            else
            {
                LblEstado.Text = "¡The authentication entered is incorrect!";
                Clases.EstadoSeccion.InicioSesion = false;
            }

            cnxn.Close();

            


        }
    }
}
