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
    public partial class Caps : UserControl
    {
        Font TamañoGrande = new Font("Bebas", 27);
        Font TamañoGrande2 = new Font("Bebas", 13);

        Font Normal = new Font("Bebas", 10);
        Font Normal2 = new Font("Bebas", 10);

        public Caps()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PanelCajaCap2.Width > 103)
            {
                PtbCap1.Size = new Size(59, 64);
                PtbCap2.Size = new Size(59, 64);
                PtbCap3.Size = new Size(59, 64);
                PtbCap4.Size = new Size(59, 64);

                LblMarcaCap1.Font = TamañoGrande;
                LblMarcaCap2.Font = TamañoGrande;
                LblMarcaCap3.Font = TamañoGrande;
                LblMarcaCap4.Font = TamañoGrande;

                LblPrecioCap4.Font = TamañoGrande2;
                LblPrecioCap3.Font = TamañoGrande2;
                LblPrecioCap2.Font = TamañoGrande2;
                LblPrecioCap1.Font = TamañoGrande2;

              
            }
            else
            {
                PtbCap1.Size = new Size(39, 44);
                PtbCap2.Size = new Size(39, 44);
                PtbCap3.Size = new Size(39, 44);
                PtbCap4.Size = new Size(39, 44);

                LblMarcaCap1.Font = Normal;
                LblMarcaCap2.Font = Normal;
                LblMarcaCap3.Font = Normal;
                LblMarcaCap4.Font = Normal;

                LblPrecioCap4.Font = Normal2;
                LblPrecioCap3.Font = Normal2;
                LblPrecioCap2.Font = Normal2;
                LblPrecioCap1.Font = Normal2;

              
            }
        }
    }
}
