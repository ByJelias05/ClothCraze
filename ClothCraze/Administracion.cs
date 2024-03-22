using ClothCraze.Modales.Administraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ClothCraze
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            PanelContenedorControladores.Controls.Clear();

            var componente = new AllUsers();
            PanelContenedorControladores.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;

            //PanelContenedorControladores.Controls.Add(new AllUsers());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            PanelContenedorControladores.Controls.Clear();

            var componente = new AllSucursales();
            PanelContenedorControladores.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            PanelContenedorControladores.Controls.Clear();

            var componente = new AllProducts();
            PanelContenedorControladores.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            PanelContenedorControladores.Controls.Clear();

            var componente = new AllReports();
            PanelContenedorControladores.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;
        }

        private void BtnMisOrdenes_Click(object sender, EventArgs e)
        {
            PanelContenedorControladores.Controls.Clear();

            var componente = new AllBuys();
            PanelContenedorControladores.Controls.Add(componente);
            componente.Dock = DockStyle.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Clases.Administracion.Deslizar == true)
            {
                guna2Transition1.ShowSync(PanelEditProductos);
            }
            else
            {
                guna2Transition1.HideSync(PanelEditProductos);
            }
        }

        private void PtbImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                PtbImage.Image = Image.FromFile(dialogo.FileName);
                PtbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void BtnGUardar_Click(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "INSERT INTO Productos (Vestimenta, Tipo, Marca, Size, Color, Precio, Imagen) " +
                "VALUES(@vVestimenta, @vTipo, @vMarca, @vSize, @vColor, @vPrecio, @vImagen)";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            MemoryStream memoria = new MemoryStream();

            PtbImage.Image.Save(memoria, ImageFormat.Png);

            string precio = TxtPrecio.Text;
            int Price = int.Parse(precio);

            cmd.Parameters.AddWithValue("@vVestimenta", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@vTipo", CmbTipo.Text);
            cmd.Parameters.AddWithValue("@vMarca", CmbMarca.Text);
            cmd.Parameters.AddWithValue("@vSize", CmbSize.Text);
            cmd.Parameters.AddWithValue("@vColor", CmbColor.Text);
            cmd.Parameters.AddWithValue("@vPrecio", Price);
            cmd.Parameters.AddWithValue("@vImagen", memoria.GetBuffer());

            cmd.ExecuteNonQuery();

            cnxn.Close();

            cnxn.Open();

            string consulta2 = "INSERT INTO InfoAdmin (NombreProducto, CantidadTotal) VALUES (@vNombreProducto, @vCantidadTotal)";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);

            string Cantidad = TxtCount.Text;
            int Count = int.Parse(Cantidad);

            cmd2.Parameters.AddWithValue("@vNombreProducto", TxtNombre.Text);
            cmd2.Parameters.AddWithValue("@vCantidadTotal", Count);

            cmd2.ExecuteNonQuery();

            cnxn.Close();

            MessageBox.Show("Add");
        }
    }
}
