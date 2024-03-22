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


namespace ClothCraze.Sliders
{
    public partial class SlideGeneral : UserControl
    {
        Font TamañoGrande = new Font("Bebas", 27);
        Font TamañoGrande2 = new Font("Bebas", 13);

        Font Normal = new Font("Bebas", 10);
        Font Normal2 = new Font("Bebas", 10);

        public SlideGeneral()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Clases.Ocultar.EstadoPantalla == true)
            {
                SlideOne.Stop();
                SlideTwo.Stop();
                SlideThree.Stop();
                SlideFour.Stop();

                PanelGorra.Visible = false;
                PanelPantalones.Visible = false;
                PanelCamisetas.Visible = false;
                //PanelTenis.Visible = false;
            }
            else
            {
                SlideOne.Start();

                if(PanelPantalones.Visible == true || PanelGorra.Visible == true)
                {
                    SlideOne.Stop();
                }

                if(PanelCamisetas.Visible == true)
                {
                    SlideOne.Start();
                }

               
            }
           

            if (PanelCajaCamiseta2.Width > 103)
            {
                PtbCamiseta1.Size = new Size(59, 64);
                PtbCamiseta2.Size = new Size(59, 64);
                PtbCamiseta3.Size = new Size(59, 64);
                PtbCamiseta4.Size = new Size(59, 64);

                LblMarcaCamiseta1.Font = TamañoGrande;
                LblMarcaCamiseta2.Font = TamañoGrande;
                LblMarcaCamiseta3.Font = TamañoGrande;
                LblMarcaCamiseta4.Font = TamañoGrande;

                LblPrecioCamiseta4.Font = TamañoGrande2;
                LblPrecioCamiseta3.Font = TamañoGrande2;
                LblPrecioCamiseta2.Font = TamañoGrande2;
                LblPrecioCamiseta1.Font = TamañoGrande2;



                //-----------Pants-----------//


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


                //-----------Shoes-----------//

                PtbTeni1.Size = new Size(59, 64);
                PtbTeni2.Size = new Size(59, 64);
                PtbTeni3.Size = new Size(59, 64);
                PtbTeni4.Size = new Size(59, 64);

                LblMarcaTenis1.Font = TamañoGrande;
                LblMarcaTenis2.Font = TamañoGrande;
                LblMarcaTenis3.Font = TamañoGrande;
                LblMarcaTenis4.Font = TamañoGrande;

                LblPrecioTeni4.Font = TamañoGrande2;
                LblPrecioTeni3.Font = TamañoGrande2;
                LblPrecioTeni2.Font = TamañoGrande2;
                LblPrecioTeni1.Font = TamañoGrande2;



                //-----------Caps-----------//


                PtbCap1.Size = new Size(59, 64);
                PtbCap2.Size = new Size(59, 64);
                PtbCap3.Size = new Size(59, 64);
                PtbCap4.Size = new Size(59, 64);

                LblMarcaCap1.Font = TamañoGrande;
                LblMarcaCap2.Font = TamañoGrande;
                LblMarcaCap3.Font = TamañoGrande;
                LblMarcaCap4.Font = TamañoGrande;

                LblPrecioCap4.Font = TamañoGrande2;
                LblPrecioCap3.Font = TamañoGrande2;
                LblPrecioCap2.Font = TamañoGrande2;
                LblPrecioCap1.Font = TamañoGrande2;

            }
            else
            {
                PtbCamiseta1.Size = new Size(39, 44);
                PtbCamiseta2.Size = new Size(39, 44);
                PtbCamiseta3.Size = new Size(39, 44);
                PtbCamiseta4.Size = new Size(39, 44);

                LblMarcaCamiseta1.Font = Normal;
                LblMarcaCamiseta2.Font = Normal;
                LblMarcaCamiseta3.Font = Normal;
                LblMarcaCamiseta4.Font = Normal;

                LblPrecioCamiseta4.Font = Normal2;
                LblPrecioCamiseta3.Font = Normal2;
                LblPrecioCamiseta2.Font = Normal2;
                LblPrecioCamiseta1.Font = Normal2;



                //-----------Pants-----------//



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



                //-----------Shoes-----------//



                PtbTeni1.Size = new Size(39, 44);
                PtbTeni2.Size = new Size(39, 44);
                PtbTeni3.Size = new Size(39, 44);
                PtbTeni4.Size = new Size(39, 44);

                LblMarcaTenis1.Font = Normal;
                LblMarcaTenis2.Font = Normal;
                LblMarcaTenis3.Font = Normal;
                LblMarcaTenis4.Font = Normal;

                LblPrecioTeni4.Font = Normal2;
                LblPrecioTeni3.Font = Normal2;
                LblPrecioTeni2.Font = Normal2;
                LblPrecioTeni1.Font = Normal2;



                //-----------Caps-----------//



                PtbCap1.Size = new Size(39, 44);
                PtbCap2.Size = new Size(39, 44);
                PtbCap3.Size = new Size(39, 44);
                PtbCap4.Size = new Size(39, 44);

                LblMarcaCap1.Font = Normal;
                LblMarcaCap2.Font = Normal;
                LblMarcaCap3.Font = Normal;
                LblMarcaCap4.Font = Normal;

                LblPrecioCap4.Font = Normal2;
                LblPrecioCap3.Font = Normal2;
                LblPrecioCap2.Font = Normal2;
                LblPrecioCap1.Font = Normal2;
            }
        }

        private void SlideGeneral_Load(object sender, EventArgs e)
        {
            DataShoe();
            DataCaps();
            DataPants();
            DataTshirts();
        }

        private void SlideOne_Tick(object sender, EventArgs e)
        {
            PanelTenis.BringToFront();
            Transitions.ShowSync(PanelTenis);
           

            if(PanelCamisetas.Visible == true)
            {
                Transitions.HideSync(PanelCamisetas);
                SlideFour.Stop();
            }

            SlideTwo.Start();

        }

        private void SlideTwo_Tick(object sender, EventArgs e)
        {
            try
            {
                PanelPantalones.BringToFront();
                Transitions.ShowSync(PanelPantalones);


                if (PanelPantalones.Visible == true)
                {
                    Transitions.HideSync(PanelTenis);
                    SlideOne.Stop();
                }

                SlideThree.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Test");
            }
        }

        private void SlideThree_Tick(object sender, EventArgs e)
        {
            try
            {
                PanelGorra.BringToFront();
                Transitions.ShowSync(PanelGorra);


                if (PanelGorra.Visible == true)
                {
                    Transitions.HideSync(PanelPantalones);
                    SlideTwo.Stop();
                }

                SlideFour.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Test");
            }
        }

        private void SlideFour_Tick(object sender, EventArgs e)
        {
            PanelCamisetas.BringToFront();
            Transitions.ShowSync(PanelCamisetas);
            

            if(PanelCamisetas.Visible == true)
            {
                Transitions.HideSync(PanelGorra);
                SlideThree.Stop();
            }

            SlideOne.Start();
        }

        public void DataPants()
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

            Image image = Image.FromStream(imagen);

            PtbPantalon1.Image = image;
            LblMarcaPantalon1.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
            LblPrecioPantalon1.Text = "$"+ dt.Rows[0][4].ToString() + " US";

            //Segundo Contenedor

            Byte[] archivo2 = (byte[])dt.Rows[1][5];
            Stream imagen2 = new MemoryStream(archivo2);

            Image image2 = Image.FromStream(imagen2);

            PtbPantalon2.Image = image2;
            LblMarcaPantalon2.Text = dt.Rows[1][2].ToString() + " " + dt.Rows[1][3].ToString();
            LblPrecioPantalon2.Text = "$"+ dt.Rows[1][4].ToString() + " US";

            //Tercer Contenedor

            Byte[] archivo3 = (byte[])dt.Rows[2][5];
            Stream imagen3 = new MemoryStream(archivo3);

            Image image3 = Image.FromStream(imagen3);

            PtbPantalon3.Image = image3;
            LblMarcaPantalon3.Text = dt.Rows[2][2].ToString() + " " + dt.Rows[2][3].ToString();
            LblPrecioPantalon3.Text = "$"+ dt.Rows[2][4].ToString() + " US";

            //Cuarto Contenedor

            Byte[] archivo4 = (byte[])dt.Rows[3][5];
            Stream imagen4 = new MemoryStream(archivo4);

            Image image4 = Image.FromStream(imagen4);

            PtbPantalon4.Image = image4;
            LblMarcaPantalon4.Text = dt.Rows[3][2].ToString() + " " + dt.Rows[3][3].ToString();
            LblPrecioPantalon4.Text = "$"+ dt.Rows[3][4].ToString() + " US";

            cnxn.Close();
        }

        public void DataTshirts()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM SlideMaxSold WHERE Tipo = 'T-Shirt'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            //Primer Contenedor

            Byte[] archivo = (byte[])dt.Rows[0][5];
            Stream imagen = new MemoryStream(archivo);

            Image image = Image.FromStream(imagen);

            PtbCamiseta1.Image = image;
            LblMarcaCamiseta1.Text = "SHIRT" + " " + dt.Rows[0][3].ToString();
            LblPrecioCamiseta1.Text = "$"+ dt.Rows[0][4].ToString() + " US";

            //Segundo Contenedor

            Byte[] archivo2 = (byte[])dt.Rows[1][5];
            Stream imagen2 = new MemoryStream(archivo2);

            Image image2 = Image.FromStream(imagen2);

            PtbCamiseta2.Image = image2;
            LblMarcaCamiseta2.Text = "SHIRT" + " " + dt.Rows[1][3].ToString();
            LblPrecioCamiseta2.Text = "$"+ dt.Rows[1][4].ToString() + " US";

            //Tercer Contenedor

            Byte[] archivo3 = (byte[])dt.Rows[2][5];
            Stream imagen3 = new MemoryStream(archivo3);

            Image image3 = Image.FromStream(imagen3);

            PtbCamiseta3.Image = image3;
            LblMarcaCamiseta3.Text = "SHIRT" + " " + dt.Rows[2][3].ToString();
            LblPrecioCamiseta3.Text = "$"+ dt.Rows[2][4].ToString() + " US";

            //Cuarto Contenedor

            Byte[] archivo4 = (byte[])dt.Rows[3][5];
            Stream imagen4 = new MemoryStream(archivo4);

            Image image4 = Image.FromStream(imagen4);

            PtbCamiseta4.Image = image4;
            LblMarcaCamiseta4.Text = "SHIRT" + " " + dt.Rows[3][3].ToString();
            LblPrecioCamiseta4.Text = "$"+ dt.Rows[3][4].ToString() + " US";

            cnxn.Close();
        }

        public void DataCaps()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM SlideMaxSold WHERE Tipo = 'Cap'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            //Primer Contenedor

            Byte[] archivo = (byte[])dt.Rows[0][5];
            Stream imagen = new MemoryStream(archivo);

            Image image = Image.FromStream(imagen);

            PtbCap1.Image = image;
            LblMarcaCap1.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
            LblPrecioCap1.Text = "$"+ dt.Rows[0][4].ToString() + " US";

            //Segundo Contenedor

            Byte[] archivo2 = (byte[])dt.Rows[1][5];
            Stream imagen2 = new MemoryStream(archivo2);

            Image image2 = Image.FromStream(imagen2);

            PtbCap2.Image = image2;
            LblMarcaCap2.Text = dt.Rows[1][2].ToString() + " " + dt.Rows[1][3].ToString();
            LblPrecioCap2.Text = "$"+ dt.Rows[1][4].ToString() + " US";

            //Tercer Contenedor

            Byte[] archivo3 = (byte[])dt.Rows[2][5];
            Stream imagen3 = new MemoryStream(archivo3);

            Image image3 = Image.FromStream(imagen3);

            PtbCap3.Image = image3;
            LblMarcaCap3.Text = dt.Rows[2][2].ToString() + "  " + dt.Rows[2][3].ToString();
            LblPrecioCap3.Text = "$"+ dt.Rows[2][4].ToString() + " US";

            //Cuarto Contenedor

            Byte[] archivo4 = (byte[])dt.Rows[3][5];
            Stream imagen4 = new MemoryStream(archivo4);

            Image image4 = Image.FromStream(imagen4);

            PtbCap4.Image = image4;
            LblMarcaCap4.Text = dt.Rows[3][2].ToString() + "  " + dt.Rows[3][3].ToString();
            LblPrecioCap4.Text = "$"+ dt.Rows[3][4].ToString() + " US";

            cnxn.Close();
        }

        public void DataShoe()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM SlideMaxSold WHERE Tipo = 'Shoe'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            //Primer Contenedor

            Byte[] archivo = (byte[])dt.Rows[0][5];
            Stream imagen = new MemoryStream(archivo);

            Image image = Image.FromStream(imagen);

            PtbTeni1.Image = image;
            LblMarcaTenis1.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
            LblPrecioTeni1.Text = "$"+ dt.Rows[0][4].ToString() + " US";

            //Segundo Contenedor

            Byte[] archivo2 = (byte[])dt.Rows[1][5];
            Stream imagen2 = new MemoryStream(archivo2);

            Image image2 = Image.FromStream(imagen2);

            PtbTeni2.Image = image2;
            LblMarcaTenis2.Text = dt.Rows[1][2].ToString() + " " + dt.Rows[1][3].ToString();
            LblPrecioTeni2.Text = "$"+ dt.Rows[1][4].ToString() + " US";

            //Tercer Contenedor

            Byte[] archivo3 = (byte[])dt.Rows[2][5];
            Stream imagen3 = new MemoryStream(archivo3);

            Image image3 = Image.FromStream(imagen3);

            PtbTeni3.Image = image3;
            LblMarcaTenis3.Text = dt.Rows[2][2].ToString() + " " + dt.Rows[2][3].ToString();
            LblPrecioTeni3.Text = "$"+ dt.Rows[2][4].ToString() + " US";

            //Cuarto Contenedor

            Byte[] archivo4 = (byte[])dt.Rows[3][5];
            Stream imagen4 = new MemoryStream(archivo4);

            Image image4 = Image.FromStream(imagen4);

            PtbTeni4.Image = image4;
            LblMarcaTenis4.Text = dt.Rows[3][2].ToString() + " " + dt.Rows[3][3].ToString();
            LblPrecioTeni4.Text = "$"+ dt.Rows[3][4].ToString() + " US";

            cnxn.Close();
        }
    }


}
