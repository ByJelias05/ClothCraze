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
    public partial class AllReports : UserControl
    {
        public AllReports()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void AllReports_Load(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Reporte";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CmbUsuarios.Items.Add(dt.Rows[i][9].ToString());
            }

            cnxn.Close();
        }

     

        private void CmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnxn.Open();

            string consulta = "SELECT * FROM Reporte WHERE Usuario = '"+ CmbUsuarios.Text +"'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            LblTipoReporte.Text = dt.Rows[0][1].ToString();
            LblReporte.Text = dt.Rows[0][2].ToString();
            LblUsuario.Text = "-" + dt.Rows[0][9].ToString();

            for (int i = 3; i <= 5; i++)
            {
                Byte[] archivo = (byte[])dt.Rows[0][i];
                Stream imagen = new MemoryStream(archivo);

                Image img = Image.FromStream(imagen);

                if (PtbPrueba1.Image == null)
                {
                    PtbPrueba1.Image = img;
                }
                else if (PtbPrueba2.Image == null)
                {
                    PtbPrueba2.Image = img;
                }
                else if (PtbPrueba3.Image == null)
                {
                    PtbPrueba3.Image = img;
                }
            }

            cnxn.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string Usuario = LblUsuario.Text;

            string Estado = "Visto";

            cnxn.Open();

            string consulta = "UPDATE Reporte SET Respuesta = '"+ TxtResponder.Text +"', Visto = '"+ Estado +"' WHERE Usuario = '"+ Usuario.Substring(1) +"' AND Comentario = '"+ LblReporte.Text +"'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Report sent");
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LblReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
