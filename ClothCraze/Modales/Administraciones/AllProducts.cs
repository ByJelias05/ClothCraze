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

namespace ClothCraze.Modales.Administraciones
{
    public partial class AllProducts : UserControl
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public void Productos(string Vestimenta, string Tipo, string Marca, string Size, string Color, string Precio, Image Imagen)
        {
            var componente = new Administraciones.LineProduct();
            ContenedorProductos.Controls.Add(componente);
            componente.Dock = DockStyle.Top;

            componente.Vestimenta = Vestimenta;
            componente.Tipo = Tipo;
            componente.Marca = Marca;
            componente.Tamaño = Size;
            componente.Color = Color;
            componente.Precio = Precio;
            componente.Imagen = Imagen;


        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Productos";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adp.Fill(dt);

            for(int i = 0;  i < dt.Rows.Count; i++)
            {
                Byte[] archivo = (byte[])dt.Rows[i][7];
                Stream imagen = new MemoryStream(archivo);
                
                Image img = Image.FromStream(imagen);

                Productos(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), img);
            }

            cnxn.Close();
        }
    }
}
