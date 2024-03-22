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
    public partial class LineRestProducts : UserControl
    {
        public LineRestProducts()
        {
            InitializeComponent();
        }

        public string VEstimenta
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

        public int porcentahe
        {
            get
            {
                return BarraProgreso.Value;
            }
            set
            {
                BarraProgreso.Value = value;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //this.Size = new System.Drawing.Size(LblVestimenta.Width, 122);
            BarraProgreso.Text = porcentahe.ToString();
        }
    }
}
