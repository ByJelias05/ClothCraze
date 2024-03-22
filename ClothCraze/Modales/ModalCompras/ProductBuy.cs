using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Modales.ModalCompras
{
    public partial class ProductBuy : UserControl
    {
        public ProductBuy()
        {
            InitializeComponent();
        }

        public Image Imagen
        {
            get
            {
                return PtbImagen.Image;
            }
            set
            {
                PtbImagen.Image = value;
            }
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



        public string Cantidad
        {
            get
            {
                return LblCantidad.Text;   
            }
            set
            {
                LblCantidad.Text = value;
            }
        }


        public string Precio
        {
            get
            {
                return LblPrecio.Text;
            }
            set
            {
                LblPrecio.Text = value;
            }
        }

       
    }
}
