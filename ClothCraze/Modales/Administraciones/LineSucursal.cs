using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.Administraciones
{
    public partial class LineSucursal : UserControl
    {
        public LineSucursal()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public string Pais
        {
            get
            {
                return LblPais.Text;
            }
            set
            {
                LblPais.Text = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return LblCiudad.Text;
            }
            set
            {
                LblCiudad.Text = value;
            }
        }

        public string Tipo
        {
            get
            {
                return LblTipo.Text;
            }
            set
            {
                LblTipo.Text = value;
            }
        }


        public string Longitud
        {
            get
            {
                return LblLongitud.Text;
            }
            set
            {
                LblLongitud.Text = value;
            }
        }

        public string Latitud
        {
            get
            {
                return LblLatitud.Text;
            }
            set
            {
                LblLatitud.Text = value;
            }
        }


        public string IDEliminar
        {
            get
            {
                return BtnDelete.Name;
            }
            set
            {
                BtnDelete.Name = value;
            }
        }

        public string IDActualizar
        {
            get
            {
                return BtnUpdate.Name;
            }
            set
            {
                BtnUpdate.Name = value;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Clases.Administracion.IsUpdate = false;

            string ExtraerID = IDEliminar;
            int ID = int.Parse(ExtraerID);

            Clases.Administracion.IdParaAccion = ID;


            cnxn.Open();

            string consulta = "DELETE FROM Sucursales WHERE IdSucursal = "+ ID +"";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            
            cmd.ExecuteNonQuery();
            
            cnxn.Close();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Clases.Administracion.IsUpdate = true;

            string ExtraerID = IDActualizar;
            int ID = int.Parse(ExtraerID);

            Clases.Administracion.IdParaAccion = ID;
        }
    }
}
