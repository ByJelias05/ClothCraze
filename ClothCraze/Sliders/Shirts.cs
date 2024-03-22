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
    public partial class Shirts : UserControl
    {
        Font TamañoGrande = new Font("Bebas", 27);
        Font TamañoGrande2 = new Font("Bebas", 13);

        Font Normal = new Font("Bebas", 10);
        Font Normal2 = new Font("Bebas", 10);

        public Shirts()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PanelCajaCamiseta2.Width > 103)
            {
                PtbCamiseta1.Size = new Size(59, 64);
                PtbCamiseta2.Size = new Size(59, 64);
                PtbCamiseta3.Size = new Size(59, 64);
                PtbCamiseta4.Size = new Size(59, 64);

                LblMarcaCamiseta1.Font = TamañoGrande;
                LblMarcaCamiseta2.Font = TamañoGrande;
                LblMarcaCamiseta3.Font = TamañoGrande;
                LblMarcaCamiseta4.Font = TamañoGrande;

                LblPrecioCamiseta4.Font = TamañoGrande2;
                LblPrecioCamiseta3.Font = TamañoGrande2;
                LblPrecioCamiseta2.Font = TamañoGrande2;
                LblPrecioCamiseta1.Font = TamañoGrande2;

              
            }
            else
            {
                PtbCamiseta1.Size = new Size(39, 44);
                PtbCamiseta2.Size = new Size(39, 44);
                PtbCamiseta3.Size = new Size(39, 44);
                PtbCamiseta4.Size = new Size(39, 44);

                LblMarcaCamiseta1.Font = Normal;
                LblMarcaCamiseta2.Font = Normal;
                LblMarcaCamiseta3.Font = Normal;
                LblMarcaCamiseta4.Font = Normal;

                LblPrecioCamiseta4.Font = Normal2;
                LblPrecioCamiseta3.Font = Normal2;
                LblPrecioCamiseta2.Font = Normal2;
                LblPrecioCamiseta1.Font = Normal2;

              
            }
        }
    }
}
