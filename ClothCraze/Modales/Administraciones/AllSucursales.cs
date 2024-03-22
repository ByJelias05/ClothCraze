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
    public partial class AllSucursales : UserControl
    {
        public AllSucursales()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public void Sucursales(string Pais, string Ciudad, string Tipo, string Longitud, string Latitud, string IDEliminar, string IDActualizar)
        {
            var componente = new LineSucursal();   
            PanelContenedorSucursales.Controls.Add(componente);
            componente.Dock = DockStyle.Top;
            componente.BringToFront();
            componente.Padding = new Padding(5, 5, 5, 5);

            componente.Pais = Pais;
            componente.Ciudad = Ciudad;
            componente.Tipo = Tipo;
            componente.Longitud = Longitud;
            componente.Latitud = Latitud;
            componente.IDActualizar = IDActualizar;
            componente.IDEliminar = IDEliminar;
        }

        private void AllSucursales_Load(object sender, EventArgs e)
        {
            SubidaData();
        }

        public void SubidaData()
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Sucursales";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cnxn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ExtraerIdL = dt.Rows[i][4].ToString();
                string ExtraerIdLat = dt.Rows[i][5].ToString();

                string ID = dt.Rows[i][0].ToString();

                Sucursales(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), ExtraerIdL, ExtraerIdLat, ID, ID);
            }

     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            cnxn.Close();


            if (Clases.Administracion.IsUpdate == true)
            {
                if(Clases.Administracion.IdParaAccion.ToString() != null || Clases.Administracion.IdParaAccion != 0)
                {
                    cnxn.Open();

                    string consulta = "SELECT * FROM Sucursales WHERE IdSucursal = "+ Clases.Administracion.IdParaAccion +"";

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    TxtCountry.Text = dt.Rows[0][1].ToString();
                    TxtCity.Text = dt.Rows[0][2].ToString();
                    CmbBranch.Text = dt.Rows[0][3].ToString();
                    TxtLongitude.Text = dt.Rows[0][4].ToString();
                    TxtLatitude.Text = dt.Rows[0][5].ToString();

                    cnxn.Close() ;

                    lblid.Text = Clases.Administracion.IdParaAccion.ToString();

                    if(Clases.Administracion.IsUpdate == true)
                    {
                        Clases.Administracion.IsUpdate = false;
                    }
                }
            }
        }


        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(Clases.Administracion.IsUpdate == true || lblid.Text != "")
            {
                string ExtraerLong = TxtLongitude.Text;
                double Long = Convert.ToDouble(ExtraerLong);

                string ExtraerLat = TxtLatitude.Text;
                double Lat = Convert.ToDouble(ExtraerLat);

                cnxn.Open();

                string consulta = "UPDATE Sucursales SET Pais = '"+ TxtCountry.Text +"', Ciudad = '"+ TxtCity.Text +"', Tipo = '"+ CmbBranch.Text +"', LongitudPais = "+ Long +", LatitudPais = "+ Lat +" WHERE IdSucursal = "+ Clases.Administracion.IdParaAccion +"";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);

                cmd.ExecuteNonQuery();

                cnxn.Close();


                MessageBox.Show("Update");

                PanelContenedorSucursales.Controls.Clear();
                SubidaData();

                //lblid.Text = "";


            }

            if(CheckAgregarSucursal.Checked)
            {
                try
                {
                    cnxn.Open();

                    string consulta = "INSERT INTO Sucursales (Pais, Ciudad, Tipo, LongitudPais, LatitudPais)" +
                        "VALUES (@vPais, @vCiudad, @vTipo, @vLongitudPais, @vLatitudPais)";

                    string AddLat = TxtLatitude.Text;
                    double Lat = Convert.ToDouble(AddLat);

                    string AddLon = TxtLongitude.Text;
                    double Long = Convert.ToDouble(AddLon);

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);

                    cmd.Parameters.Add("@vPais", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@vCiudad", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@vTipo", SqlDbType.NVarChar);
                    cmd.Parameters.AddWithValue("@vLongitudPais", Long);
                    cmd.Parameters.AddWithValue("@vLatitudPais", Lat);

                    cmd.Parameters["@vPais"].Value = TxtCountry.Text;
                    cmd.Parameters["@vCiudad"].Value = TxtCity.Text;
                    cmd.Parameters["@vTipo"].Value = CmbBranch.Text;

                    cmd.ExecuteNonQuery();

                    cnxn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Completa los campos");
                }
           
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                cnxn.Open();

                string consulta = "SELECT * FROM Sucursales";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cnxn.Close();

                if (PanelContenedorSucursales.Controls.Count != dt.Rows.Count)
                {
                    PanelContenedorSucursales.Controls.Clear();
                    SubidaData();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
