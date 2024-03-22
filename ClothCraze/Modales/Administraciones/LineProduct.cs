using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.Administraciones
{
    public partial class LineProduct : UserControl
    {
        public LineProduct()
        {
            InitializeComponent();
        }

        public string Vestimenta
        {
            get
            {
                return LblVestimenta.Text;
            }
            set
            {
                LblVestimenta.Text = value;
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

        public string Marca
        {
            get
            {
                return LblMarca.Text;
            }
            set
            {
                LblMarca.Text = value;
            }


        }

        public string Tamaño
        {
            get
            {
                return LblSize.Text;
            }
            set
            {
                LblSize.Text = value;
            }


        }

        public string Color
        {
            get
            {
                return LblColor.Text;
            }
            set
            {
                LblColor.Text = value;
            }


        }

        public string Precio
        {
            get
            {
                return LblPrice.Text;
            }
            set
            {
                LblPrice.Text = value;
            }

        }

        public Image Imagen
        {
            get
            {
                return PtbImage.Image;
            }
            set
            {
                PtbImage.Image = value;
            }


        }
    }
}
