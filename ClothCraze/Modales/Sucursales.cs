using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;



using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Data.SqlClient;

namespace ClothCraze.Modales
{
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
            
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        GMarkerGoogle marker;
        GMapOverlay overlay;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Clases.EstadoSeccion.TipoUsuario == "Administrador")
            {
                   this.Hide();
                ShowInTaskbar = false;

                
            }

          
        }

        //Este ID inicia en 0 porque la primea sucursal tiene el ID 1 y cuando se ejecute el boton 
        //de siguiente me mande a la primera sucursal que tiene le ID 1.. si iniciara en 1 me madara a la
        //seguna sucursal dicho ID es 2.
        public int ID = 0;

        public DataTable data;

        public void ExtraerID()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Sucursales";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            data = dt;  

            cnxn.Close();

        }

        private void Modal_Load_1(object sender, EventArgs e)
        {
            ExtraerID();

            if (ID < data.Rows.Count /*|| ID == 0*/)
            {
                ID++;
            }



            cnxn.Open();

            string consulta = "SELECT * FROM Sucursales WHERE IdSucursal = "+ 1 +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            cnxn.Close();

            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GoogleHybridMapProvider.Instance;
            Mapa.MaxZoom = 18;
            Mapa.Zoom = 18;

            string valorLat = dt.Rows[0][5].ToString();
            double OriginalLat = double.Parse(valorLat);

            string valorLong = dt.Rows[0][4].ToString();
            double OriginalLong = double.Parse(valorLong);

            Pais.Text = dt.Rows[0][1].ToString();
            Ciudad.Text = dt.Rows[0][2].ToString();
            Sucursal.Text = dt.Rows[0][3].ToString();

            Mapa.Position = new PointLatLng(OriginalLat, OriginalLong);
        }

        

        private void Mapa_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ExtraerID();

            if (ID < data.Rows.Count /*|| ID == 0*/)
            {
                ID++;
            }
           


            cnxn.Open();

            string consulta = "SELECT * FROM Sucursales WHERE IdSucursal = "+ ID +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            cnxn.Close();

            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GoogleHybridMapProvider.Instance;
            Mapa.MaxZoom = 18;
            Mapa.Zoom = 18;

            string valorLat = dt.Rows[0][5].ToString();
            double OriginalLat = double.Parse(valorLat);

            string valorLong = dt.Rows[0][4].ToString();
            double OriginalLong = double.Parse(valorLong);

            Pais.Text = dt.Rows[0][1].ToString();
            Ciudad.Text = dt.Rows[0][2].ToString();
            Sucursal.Text = dt.Rows[0][3].ToString();


            Mapa.Position = new PointLatLng(OriginalLat, OriginalLong);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //ExtraerID();

             if (data.Rows.Count == ID)
             {
                if (ID != 1)
                {
                    ID--;
                }
             }

            cnxn.Open();

            string consulta = "SELECT * FROM Sucursales WHERE IdSucursal = "+ ID +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            cnxn.Close();

            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GoogleHybridMapProvider.Instance;
            Mapa.MaxZoom = 18;
            Mapa.Zoom = 18;

            string valorLat = dt.Rows[0][5].ToString();
            double OriginalLat = double.Parse(valorLat);

            string valorLong = dt.Rows[0][4].ToString();
            double OriginalLong = double.Parse(valorLong);

            Pais.Text = dt.Rows[0][1].ToString();
            Ciudad.Text = dt.Rows[0][2].ToString();
            Sucursal.Text = dt.Rows[0][3].ToString();

            Mapa.Position = new PointLatLng(OriginalLat, OriginalLong);
        }
    }
}
