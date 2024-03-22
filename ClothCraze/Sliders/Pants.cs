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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothCraze.Sliders
{
    public partial class Pants : UserControl
    {
        Font TamañoGrande = new Font("Bebas", 27);
        Font TamañoGrande2 = new Font("Bebas", 13);

        Font Normal = new Font("Bebas", 10);
        Font Normal2 = new Font("Bebas", 10);

        public Pants()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PanelCajaPantalon2.Width > 103)
            {
                

                PtbPantalon1.Size = new Size(59, 64);
                PtbPantalon2.Size = new Size(59, 64);
                PtbPantalon3.Size = new Size(59, 64);
                PtbPantalon4.Size = new Size(59, 64);

                LblMarcaPantalon1.Font = TamañoGrande;
                LblMarcaPantalon2.Font = TamañoGrande;
                LblMarcaPantalon3.Font = TamañoGrande;
                LblMarcaPantalon4.Font = TamañoGrande;

                LblPrecioPantalon4.Font = TamañoGrande2;
                LblPrecioPantalon3.Font = TamañoGrande2;
                LblPrecioPantalon2.Font = TamañoGrande2;
                LblPrecioPantalon1.Font = TamañoGrande2;

              
            }
            else
            {
                PtbPantalon1.Size = new Size(39, 44);
                PtbPantalon2.Size = new Size(39, 44);
                PtbPantalon3.Size = new Size(39, 44);
                PtbPantalon4.Size = new Size(39, 44);

                LblMarcaPantalon1.Font = Normal;
                LblMarcaPantalon2.Font = Normal;
                LblMarcaPantalon3.Font = Normal;
                LblMarcaPantalon4.Font = Normal;

                LblPrecioPantalon4.Font = Normal2;
                LblPrecioPantalon3.Font = Normal2;
                LblPrecioPantalon2.Font = Normal2;
                LblPrecioPantalon1.Font = Normal2;

              
            }
            

        }

        private void Pants_Load(object sender, EventArgs e)
        {
            

            cnxn.Open();

            string consulta = "SELECT * FROM SlideMaxSold WHERE Tipo = 'Pant'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            //Primer Contenedor

            Byte[] archivo = (byte[])dt.Rows[0][5];
            Stream imagen = new MemoryStream(archivo);
            
            Image image =  Image.FromStream(imagen);    

            PtbPantalon1.Image = image;
            LblMarcaPantalon1.Text = dt.Rows[0][2].ToString() + dt.Rows[0][3].ToString();

            //Primer Contenedor

            Byte[] archivo2 = (byte[])dt.Rows[1][5];
            Stream imagen2 = new MemoryStream(archivo2);

            Image image2 = Image.FromStream(imagen2);

            PtbPantalon2.Image = image2;
            LblMarcaPantalon2.Text = dt.Rows[1][2].ToString() + dt.Rows[1][3].ToString();

            //Primer Contenedor

            Byte[] archivo3 = (byte[])dt.Rows[2][5];
            Stream imagen3 = new MemoryStream(archivo3);

            Image image3 = Image.FromStream(imagen3);

            PtbPantalon3.Image = image3;
            LblMarcaPantalon3.Text = dt.Rows[2][2].ToString() + dt.Rows[2][3].ToString();

            //Primer Contenedor

            Byte[] archivo4 = (byte[])dt.Rows[3][5];
            Stream imagen4 = new MemoryStream(archivo4);

            Image image4 = Image.FromStream(imagen4);

            PtbPantalon4.Image = image4;
            LblMarcaPantalon4.Text = dt.Rows[3][2].ToString() + dt.Rows[3][3].ToString();



        }
    }
}
