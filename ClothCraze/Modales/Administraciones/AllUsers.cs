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
    public partial class AllUsers : UserControl
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public void Usuarios(string Nombre, string Correo, string Contraseña, Image Foto, string TipoUsuario, string ID)
        {
            var componente = new Administraciones.LineUser();
            PanelContenedorUsuarios.Controls.Add(componente);
            componente.Dock = DockStyle.Top;
            componente.BringToFront();

            componente.Nombre = Nombre;
            componente.Correo = Correo;
            componente.Contraseña = Contraseña;
            componente.Foto = Foto;
            componente.TipoUsuario = TipoUsuario;
            componente.ID = ID;
        }

        public Image img;

        private void AllUsers_Load(object sender, EventArgs e)
        {
            cnxn.Open();

            string Consulta = "SELECT * FROM Login";

            SqlCommand cmd = new SqlCommand(Consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adp.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                

                if (dt.Rows[i][4] != null)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][4];
                    Stream imagen = new MemoryStream(archivo);

                    img = Image.FromStream(imagen);
                }

                Usuarios(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), img, dt.Rows[i][5].ToString(), dt.Rows[i][0].ToString());
            }

            cnxn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnxn.Open();

            string Consulta = "SELECT * FROM Login";

            SqlCommand cmd = new SqlCommand(Consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if(PanelContenedorUsuarios.Controls.Count != dt.Rows.Count)
            {
                PanelContenedorUsuarios.Controls.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    if (dt.Rows[i][4] != null)
                    {
                        Byte[] archivo = (byte[])dt.Rows[i][4];
                        Stream imagen = new MemoryStream(archivo);

                        img = Image.FromStream(imagen);
                    }

                    Usuarios(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), img, dt.Rows[i][5].ToString(), dt.Rows[i][0].ToString());
                }
            }

            cnxn.Close();
        }
    }
}
