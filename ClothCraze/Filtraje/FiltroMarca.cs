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
	public partial class FiltroMarca : UserControl
	{
		public FiltroMarca()
		{
			InitializeComponent();

          
		}

        private void RadioNike_CheckedChanged(object sender, EventArgs e)
        {
			if (RadioNike.Checked) 
			{
				Clases.Filtro.MarcaVestimenta = RadioNike.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }

           
        }

        private void RadioPuma_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPuma.Checked)
            {
                Clases.Filtro.MarcaVestimenta = RadioPuma.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }

            
        }

        private void RadioAdidas_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAdidas.Checked)
            {
                Clases.Filtro.MarcaVestimenta = RadioAdidas.Text;
                Clases.Filtro.EstadoFiltrado = true;
            }

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(Clases.Filtro.TipoVestimenta != null)
           {
                if (Clases.Filtro.ColorVestimenta != null || Clases.Filtro.SizeVestimenta != null)
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

        private void RadioAdidas_Click(object sender, EventArgs e)
        {
            if (RadioAdidas.Checked)
            {
                RadioAdidas.Checked = false;
                Clases.Filtro.MarcaVestimenta = null;
            }
        }

        private void RadioPuma_Click(object sender, EventArgs e)
        {
            if (RadioPuma.Checked)
            {
                RadioPuma.Checked = false;
                Clases.Filtro.MarcaVestimenta = null;
            }
        }

        private void RadioNike_Click(object sender, EventArgs e)
        {
            if (RadioNike.Checked)
            {
                RadioNike.Checked = false;
                Clases.Filtro.MarcaVestimenta = null;
            }
        }
    }
}
