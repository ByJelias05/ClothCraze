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
	public partial class FiltroColor : UserControl
	{
		public FiltroColor()
		{
			InitializeComponent();
		}

        private void RadioBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBlanco.Checked)
            {
                Clases.Filtro.ColorVestimenta = RadioBlanco.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }
            else
            {
                Clases.Filtro.ColorVestimenta = null;
            }
        }

        private void RadioNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioNegro.Checked)
            {
                Clases.Filtro.ColorVestimenta = RadioNegro.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }
            else
            {
                Clases.Filtro.ColorVestimenta = null;
            }
        }

        private void RadioGris_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioGris.Checked)
            {
                Clases.Filtro.ColorVestimenta = RadioGris.Text;
                Clases.Filtro.EstadoFiltrado = true;

          
            }
            else
            {
                Clases.Filtro.ColorVestimenta = null;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(Clases.Filtro.TipoVestimenta != null)
           {
                if (Clases.Filtro.MarcaVestimenta != null || Clases.Filtro.SizeVestimenta != null)
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

        private void RadioGris_Click(object sender, EventArgs e)
        {
            if (RadioGris.Checked)
            {
                RadioGris.Checked = false;
                Clases.Filtro.ColorVestimenta = null;
            }
        }

        private void RadioNegro_Click(object sender, EventArgs e)
        {
            if (RadioNegro.Checked)
            {
                RadioNegro.Checked = false;
                Clases.Filtro.ColorVestimenta = null;
            }
        }

        private void RadioBlanco_Click(object sender, EventArgs e)
        {
            if (RadioBlanco.Checked)
            {
                RadioBlanco.Checked = false;
                Clases.Filtro.ColorVestimenta = null;
            }

        }
    }
}
