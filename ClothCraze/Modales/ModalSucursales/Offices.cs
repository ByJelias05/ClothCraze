using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Net;
using GMap.NET.WindowsPresentation;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace ClothCraze.Modales.ModalSucursales
{
    public partial class Offices : UserControl
    {
        public Offices()
        {
            InitializeComponent();
        }

        GMarkerGoogle marker;
        GMapOverlay overlay;

        private void Offices_Load(object sender, EventArgs e)
        {
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GoogleHybridMapProvider.Instance;
            Mapa.MaxZoom = 10;
            Mapa.Zoom = 4;
            Mapa.Position = new PointLatLng(18.483402, -69.929611);

            overlay = new GMapOverlay("Maracdor");
            marker = new GMarkerGoogle(new PointLatLng(18.483402, -69.929611), GMarkerGoogleType.red);

            overlay.Markers.Add(marker);

            Mapa.Overlays.Add(overlay);
        }

        private void Mapa_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel1.FillColor = Color.Red;

            timer1.Stop();
            timer1.Start();

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = Color.White;
        }

        private void Offices_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
