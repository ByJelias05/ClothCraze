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
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;

namespace ClothCraze.Modales.ModalReporte
{
    public partial class Reporte : UserControl
    {
        public Reporte()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void BtnnReporte_Click(object sender, EventArgs e)
        {
            if(Clases.EstadoSeccion.Nombre != null)
            {
                string Estado = "NoVisto";

                cnxn.Open();

                string consulta = "INSERT INTO Reporte (Tipo, Comentario, Prueba1, Prueba2, Prueba3, Visto, Fecha, Usuario, VistoPorUsuario)" +
                    "VALUES (@vTipo, @vComentario, @vPrueba1, @vPrueba2, @vPrueba3, @vVisto, @vFecha, @vUsuario, @vVistoPorUsuario)";

                MemoryStream memoria1 = new MemoryStream();
                MemoryStream memoria2 = new MemoryStream();
                MemoryStream memoria3 = new MemoryStream();

                if(PtbPrueba1.Image != null)
                {
                    PtbPrueba1.Image.Save(memoria1, ImageFormat.Png);
                }
                if (PtbPrueba2.Image != null)
                {
                    PtbPrueba2.Image.Save(memoria2, ImageFormat.Png);
                }
                if (PtbPrueba3.Image != null)
                {
                    PtbPrueba3.Image.Save(memoria3, ImageFormat.Png);
                }


                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                cmd.Parameters.Add("@vTipo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@vComentario", SqlDbType.NVarChar);
                cmd.Parameters.Add("@vPrueba1", SqlDbType.Binary);
                cmd.Parameters.Add("@vPrueba2", SqlDbType.Binary);
                cmd.Parameters.Add("@vPrueba3", SqlDbType.Binary);
                cmd.Parameters.Add("@vVisto", SqlDbType.NVarChar);
                cmd.Parameters.Add("@vFecha", SqlDbType.Date);
                cmd.Parameters.Add("@vUsuario", SqlDbType.NVarChar);
                cmd.Parameters.Add("@vVistoPorUsuario", SqlDbType.NVarChar);

                cmd.Parameters["@vTipo"].Value = CmbTipoProblema.Text;
                cmd.Parameters["@vComentario"].Value = TxtComentario.Text;
                cmd.Parameters["@vPrueba1"].Value = memoria1.GetBuffer();
                cmd.Parameters["@vPrueba2"].Value = memoria2.GetBuffer();
                cmd.Parameters["@vPrueba3"].Value = memoria3.GetBuffer();
                cmd.Parameters["@vVisto"].Value = Estado;
                cmd.Parameters["@vFecha"].Value = DateTime.Now;
                cmd.Parameters["@vUsuario"].Value = Clases.EstadoSeccion.Nombre;
                cmd.Parameters["@vVistoPorUsuario"].Value = Estado;

                cmd.ExecuteNonQuery();

                cnxn.Close();

                MessageBox.Show("added report");


            }
            else
            {
                MessageBox.Show("You must first log in");
            }
        }

        public int Click = 0;

        private void BtnAgregarPrueba_Click(object sender, EventArgs e)
        {
            Click++;

            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                if(PtbPrueba1.Image == null && Click == 1)
                {
                    PtbPrueba1.Image = Image.FromFile(dialogo.FileName);
                    PtbPrueba1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if(PtbPrueba2.Image == null && Click == 2)
                {
                    PtbPrueba2.Image = Image.FromFile(dialogo.FileName);
                    PtbPrueba2.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (PtbPrueba3.Image == null && Click == 3)
                {
                    PtbPrueba3.Image = Image.FromFile(dialogo.FileName);
                    PtbPrueba3.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

       

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
          

            string Estado = "Visto";

            if(Clases.EstadoSeccion.Nombre != null)
            {
                if (PanelNotificaciones.Visible == true)
                {
                    guna2Transition1.HideSync(PanelNotificaciones);
                }
                else
                {
                    guna2Transition1.ShowSync(PanelNotificaciones);

                    cnxn.Open();

                    string consulta2 = "UPDATE Reporte SET VistoPorUsuario = '"+ Estado +"' WHERE Tipo = '"+ lblTipoProblema.Text +"' AND Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";
                    SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmd2.ExecuteNonQuery();

                    cnxn.Close();

                    CantidadNotificacioones.Text = dt.Rows.Count.ToString();
                }
            }

          
        }

        public DataTable CountNotificactions;

        private void Reporte_Load(object sender, EventArgs e)
        {
            if(Clases.EstadoSeccion.Nombre != null)
            {
                string Estado = "Visto";

                cnxn.Open();

                string consulta = "SELECT * FROM Reporte WHERE Respuesta != '' AND Visto = '"+ Estado +"' AND Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cnxn.Close();

                if (dt.Rows.Count > 0)
                {
                    lblTipoProblema.Text = dt.Rows[0][1].ToString();
                    TxtRespuesta.Text = dt.Rows[0][6].ToString();
                }

                cnxn.Open();

                string consulta2 = "SELECT * FROM Reporte WHERE Respuesta != '' AND Visto = '"+ Estado +"' AND Usuario = '"+ Clases.EstadoSeccion.Nombre +"' AND VistoPorUsuario != '"+ Estado +"'";

                SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                adp2.Fill(dt2);

                CountNotificactions = dt2;

                if (dt2.Rows.Count > 0)
                {
                    CantidadNotificacioones.Text = dt.Rows.Count.ToString();
                }

                cnxn.Close();
            }
        }

        private void TxtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
