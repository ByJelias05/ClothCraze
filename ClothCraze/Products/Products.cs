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

namespace ClothCraze.Products
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public Image ImagenVestimenta
        {
            get
            {
                return PtbImagen.Image;
            }
            set
            {
                PtbImagen.Image = value;
            }
        }

        public string NombreVestimenta
        {
            get
            {
                return LblVestimenta.Text;
            }
            set
            {
                LblVestimenta.Text = value;
            }
        }


        public string PrecioVestimenta
        {
            get
            {
                return LblPrecio.Text;
            }
            set
            {
                LblPrecio.Text = value;
            }
        }

       

        private void guna2Panel2_MouseHover(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(BtnFavorito);
            bunifuTransition1.ShowSync(BtnCarrito);
        }

        public DataTable Datas;

        public void AllInformationProduct()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Productos WHERE Vestimenta = '"+ NombreVestimenta +"'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Datas = dt;

            cnxn.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(Clases.EstadoSeccion.Estado == "NoLog" )
            {
                Clases.EstadoSeccion.Respuesta = "Mostrar";
            }
            else
            {
                if(CmbCantidad.SelectedItem != null)
                {
                    AllInformationProduct();

                    string ValorCmb = CmbCantidad.SelectedItem.ToString();
                    int ValorOriginal = int.Parse(ValorCmb);

                    Clases.EstadoSeccion.Respuesta = "NoMostrar";

                    cnxn.Open();

                    string consulta = "INSERT INTO ProductosCarrito (Vestimenta, Tipo, Marca, Size, Color, Precio, Imagen, Cantidad, Usuario)" +
                        "VALUES (@vVestimenta, @vTipo, @vMarca, @vSize, @vColor, @vPrecio, @vImagen, @vCantidad, @vUsuario)";

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);
                    MemoryStream memoryStream = new MemoryStream();

                    PtbImagen.Image.Save(memoryStream, ImageFormat.Png);

                    cmd.Parameters.AddWithValue("@vVestimenta", Datas.Rows[0][1].ToString());
                    cmd.Parameters.AddWithValue("@vTipo", Datas.Rows[0][2].ToString());
                    cmd.Parameters.AddWithValue("@vMarca", Datas.Rows[0][3].ToString());
                    cmd.Parameters.AddWithValue("@vSize", Datas.Rows[0][4].ToString());
                    cmd.Parameters.AddWithValue("@vColor", Datas.Rows[0][5].ToString());
                    cmd.Parameters.AddWithValue("@vPrecio", Datas.Rows[0][6].ToString());
                    cmd.Parameters.AddWithValue("@vImagen", memoryStream.GetBuffer());
                    cmd.Parameters.AddWithValue("@vCantidad", ValorOriginal);
                    cmd.Parameters.AddWithValue("@vUsuario", Clases.EstadoSeccion.Nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Agregado al carrito");

                    cnxn.Close();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la cantidad");
                }

            }

            cnxn.Open();

            string consulta2 = "SELECT * FROM ProductosCarrito WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cnxn.Close();

            Clases.Prodcutos.CantidadDeProductosEnCarrito = dt2.Rows.Count;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (Clases.EstadoSeccion.Estado == "NoLog")
            {
                Clases.EstadoSeccion.Respuesta = "Mostrar";
            
            }
            else
            {
                if (CmbCantidad.SelectedItem != null)
                {
                    AllInformationProduct();

                    string ValorCmb = CmbCantidad.SelectedItem.ToString();
                    int ValorOriginal = int.Parse(ValorCmb);

                    Clases.EstadoSeccion.Respuesta = "NoMostrar";

                    cnxn.Open();

                    string consulta = "INSERT INTO ProductosFavoritos (Vestimenta, Tipo, Marca, Size, Color, Precio, Imagen, Cantidad, Usuario)" +
                        "VALUES (@vVestimenta, @vTipo, @vMarca, @vSize, @vColor, @vPrecio, @vImagen, @vCantidad, @vUsuario)";

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);
                    MemoryStream memoryStream = new MemoryStream();

                    PtbImagen.Image.Save(memoryStream, ImageFormat.Png);

                    cmd.Parameters.AddWithValue("@vVestimenta", Datas.Rows[0][1].ToString());
                    cmd.Parameters.AddWithValue("@vTipo", Datas.Rows[0][2].ToString());
                    cmd.Parameters.AddWithValue("@vMarca", Datas.Rows[0][3].ToString());
                    cmd.Parameters.AddWithValue("@vSize", Datas.Rows[0][4].ToString());
                    cmd.Parameters.AddWithValue("@vColor", Datas.Rows[0][5].ToString());
                    cmd.Parameters.AddWithValue("@vPrecio", Datas.Rows[0][6].ToString());
                    cmd.Parameters.AddWithValue("@vImagen", memoryStream.GetBuffer());
                    cmd.Parameters.AddWithValue("@vCantidad", ValorOriginal);
                    cmd.Parameters.AddWithValue("@vUsuario", Clases.EstadoSeccion.Nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Agregado a favorito");

                    cnxn.Close();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la cantidad");
                }
            }


            cnxn.Open();

            string consulta2 = "SELECT * FROM ProductosFavoritos WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cnxn.Close();

            Clases.Prodcutos.CantidadDeProductosEnFavorito = dt2.Rows.Count;


        }

        private void Products_Load(object sender, EventArgs e)
        {
    
        }

      
    }
}
