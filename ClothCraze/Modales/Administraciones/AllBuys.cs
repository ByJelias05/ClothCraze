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
    public partial class AllBuys : UserControl
    {
        public AllBuys()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void AllBuys_Load(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT * FROM ProductosComprados WHERE EstadoPrevio IS NULL";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            DtgTodasLasCompras.DataSource = dt;

            cnxn.Close();

            cnxn.Open();

            string consulta2 = "SELECT * FROM ProductosComprados WHERE EstadoPrevio = '"+ EstadoEnviado +"'";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            DtgProductoEnviado.DataSource = dt2;

            cnxn.Close();

            cnxn.Open();

            string consulta3 = "SELECT * FROM ProductosComprados WHERE EstadoPrevio = '"+ EstadoProgreso +"'";

            SqlCommand cmd3 = new SqlCommand(consulta3, cnxn);
            SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);

            DtgProductoPais.DataSource = dt3;

            cnxn.Close();

            cnxn.Open();

            string consulta4 = "SELECT * FROM ProductosComprados WHERE EstadoPrevio = '"+ EstadoEntrega +"'";

            SqlCommand cmd4 = new SqlCommand(consulta4, cnxn);
            SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            adp4.Fill(dt4);

            DtgProductosEntregados.DataSource = dt4;

            cnxn.Close();
        }

        private void DtgTodasLasCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtgTodasLasCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnProgress.Enabled = false;
                BtnReceive.Enabled = false;
                BtnSend.Enabled = true;

                string ExtraerID = DtgTodasLasCompras.SelectedCells[0].Value.ToString();

                int ID = int.Parse(ExtraerID);

                BtnProgress.Tag = ID;
                BtnSend.Tag = ID;
                BtnReceive.Tag = ID;

              
            }
            catch (Exception)
            {

            }
        }

        public string EstadoEnviado = "Sent";

        private void BtnSend_Click_1(object sender, EventArgs e)
        {

            cnxn.Open();

            string consulta = "UPDATE ProductosComprados SET EstadoPrevio = '"+ EstadoEnviado +"' WHERE IdProductoFav = "+ BtnSend.Tag +"";  

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        public string EstadoProgreso = "In Progress";

        private void BtnProgress_Click(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "UPDATE ProductosComprados SET EstadoPrevio = '"+ EstadoProgreso +"' WHERE IdProductoFav = "+ BtnSend.Tag +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        public string EstadoEntrega = "Delivered";

        private void BtnReceive_Click(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "UPDATE ProductosComprados SET EstadoPrevio = '"+ EstadoEntrega +"' WHERE IdProductoFav = "+ BtnSend.Tag +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        private void DtgProductoEnviado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnProgress.Enabled = true;
                BtnReceive.Enabled = false;
                BtnSend.Enabled = false;

                string ExtraerID = DtgTodasLasCompras.SelectedCells[0].Value.ToString();

                int ID = int.Parse(ExtraerID);

                BtnProgress.Tag = ID;
                BtnSend.Tag = ID;
                BtnReceive.Tag = ID;

               
            }
            catch (Exception)
            {

            }
        }

        private void DtgProductoPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnReceive.Enabled = true;
                BtnSend.Enabled = false;
                BtnProgress.Enabled = false;
          
                string ExtraerID = DtgTodasLasCompras.SelectedCells[0].Value.ToString();

                int ID = int.Parse(ExtraerID);

                BtnProgress.Tag = ID;
                BtnSend.Tag = ID;
                BtnReceive.Tag = ID;

             
             
            }
            catch (Exception)
            {

            }
        }

        private void DtgProductosEntregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnSend.Enabled = false;
                BtnProgress.Enabled = false;
                BtnReceive.Enabled = false;

                string ExtraerID = DtgTodasLasCompras.SelectedCells[0].Value.ToString();

                int ID = int.Parse(ExtraerID);

                BtnProgress.Tag = ID;
                BtnSend.Tag = ID;
                BtnReceive.Tag = ID;

               
            }
            catch (Exception)
            {

            }
        }
    }
}
