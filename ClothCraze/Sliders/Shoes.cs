using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothCraze.Sliders
{
    public partial class Shoes : UserControl
    {
        Font TamañoGrande = new Font("Bebas", 27);
        Font TamañoGrande2 = new Font("Bebas", 13);

        Font Normal = new Font("Bebas", 10);
        Font Normal2 = new Font("Bebas", 10);

        public Shoes()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PanelCajaTeni2.Width > 103)
            {
                PtbTeni1.Size = new Size(59, 64);
                PtbTeni2.Size = new Size(59, 64);
                PtbTeni3.Size = new Size(59, 64);
                PtbTeni4.Size = new Size(59, 64);

                LblMarcaTenis1.Font = TamañoGrande;
                LblMarcaTenis2.Font = TamañoGrande;
                LblMarcaTenis3.Font = TamañoGrande;
                LblMarcaTenis4.Font = TamañoGrande;

                LblPrecioTeni4.Font = TamañoGrande2;
                LblPrecioTeni3.Font = TamañoGrande2;
                LblPrecioTeni2.Font = TamañoGrande2;
                LblPrecioTeni1.Font = TamañoGrande2;

              
            }
            else
            {
                PtbTeni1.Size = new Size(39, 44);
                PtbTeni2.Size = new Size(39, 44);
                PtbTeni3.Size = new Size(39, 44);
                PtbTeni4.Size = new Size(39, 44);

                LblMarcaTenis1.Font = Normal;
                LblMarcaTenis2.Font = Normal;
                LblMarcaTenis3.Font = Normal;
                LblMarcaTenis4.Font = Normal;

                LblPrecioTeni4.Font = Normal2;
                LblPrecioTeni3.Font = Normal2;
                LblPrecioTeni2.Font = Normal2;
                LblPrecioTeni1.Font = Normal2;

              
            }
        }
    }
}
