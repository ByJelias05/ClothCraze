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

namespace ClothCraze.Modales.Administraciones
{
    public partial class RestProducts : UserControl
    {
        public RestProducts()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public void Productos(string Vestimenta, int Porcentaje)
        {
            var componente = new Administraciones.LineRestProducts();
            PanelContenedor.Controls.Add(componente);
            componente.Dock = DockStyle.Left;

            componente.VEstimenta = Vestimenta;
            componente.porcentahe = Porcentaje;
        }

        private void RestProducts_Load(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT * FROM InfoAdmin";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string Porcentaje = dt.Rows[i][2].ToString();
                int Valor = int.Parse(Porcentaje);

                Productos(dt.Rows[i][1].ToString(), Valor);
            }

            cnxn.Close();
        }
    }
}
