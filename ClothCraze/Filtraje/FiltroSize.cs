using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothCraze.Filtraje
{
	public partial class FiltroSize : UserControl
	{
		public FiltroSize()
		{
			InitializeComponent();
		}

        private void RadioNiño_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioNiño.Checked)
            {
                Clases.Filtro.SizeVestimenta = RadioNiño.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }
        }

        private void RadioAdulto_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAdulto.Checked)
            {
                Clases.Filtro.SizeVestimenta = RadioAdulto.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(Clases.Filtro.TipoVestimenta != null)
           {
                if (Clases.Filtro.ColorVestimenta != null || Clases.Filtro.MarcaVestimenta != null)
                {
                    PanelRadios.Enabled = false;
                }
                else
                {
                    PanelRadios.Enabled = true;
                }
           }

            //if (Clases.Filtro.TipoVestimenta == null)
            //{
            //    PanelRadios.Enabled = false;
            //}
            //else
            //{
            //    PanelRadios.Enabled = true;
            //}

   
        }

        private void RadioAdulto_Click(object sender, EventArgs e)
        {
            if (RadioAdulto.Checked)
            {
                RadioAdulto.Checked = false;
                Clases.Filtro.SizeVestimenta = null;
            }
        }

        private void RadioNiño_Click(object sender, EventArgs e)
        {
            if (RadioNiño.Checked)
            {
                RadioNiño.Checked = false;
                Clases.Filtro.SizeVestimenta = null;
            }
        }
    }
}
