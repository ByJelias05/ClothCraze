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

namespace ClothCraze.AddProducts
{
    public partial class AddFavorite : UserControl
    {
        public AddFavorite()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY= true");

        public Image ImagenVestimenta
        {
            get
            {
                return PtbProducto.Image;
            }
            set
            {
                PtbProducto.Image = value;
            }
        }

        int IDProductsCart;

        public int ID
        {
            get
            {
                return IDProductsCart;
            }
            set
            {
                IDProductsCart = value;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "DELETE ProductosFavoritos WHERE IdProductoFav = "+ ID +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);

            cmd.ExecuteNonQuery();

            cnxn.Close();

            VerificarFav();

          
        }

        public void VerificarFav()
        {
            cnxn.Open();

            string consulta2 = "SELECT * FROM ProductosFavoritos WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cnxn.Close();

            Clases.Prodcutos.CantidadDeProductosEnFavorito = dt2.Rows.Count;
        }
    }
}
