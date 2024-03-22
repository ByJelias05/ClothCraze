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

namespace ClothCraze.Modales.ModalCompras
{
    public partial class ProductSent : UserControl
    {
        public ProductSent()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        
        public string Vestimenta
        {
            get
            {
                return lblVestimeta.Text;
            }
            set
            {
                lblVestimeta.Text = value;
            }
        }

        private void ProductSent_Load(object sender, EventArgs e)
        {
       

        }
    }


}
