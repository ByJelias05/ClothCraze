namespace ClothCraze.Modales.Administraciones
{
    partial class RestProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.lineRestProducts1 = new ClothCraze.Modales.Administraciones.LineRestProducts();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoScroll = true;
            this.PanelContenedor.BorderRadius = 25;
            this.PanelContenedor.Controls.Add(this.lineRestProducts1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.FillColor = System.Drawing.Color.White;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.PanelContenedor.Size = new System.Drawing.Size(1084, 122);
            this.PanelContenedor.TabIndex = 4;
            // 
            // lineRestProducts1
            // 
            this.lineRestProducts1.BackColor = System.Drawing.Color.Transparent;
            this.lineRestProducts1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineRestProducts1.Location = new System.Drawing.Point(15, 0);
            this.lineRestProducts1.Name = "lineRestProducts1";
            this.lineRestProducts1.porcentahe = 50;
            this.lineRestProducts1.Size = new System.Drawing.Size(104, 122);
            this.lineRestProducts1.TabIndex = 0;
            this.lineRestProducts1.VEstimenta = "Puma Sweater MD";
            // 
            // RestProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelContenedor);
            this.Name = "RestProducts";
            this.Size = new System.Drawing.Size(1084, 122);
            this.Load += new System.EventHandler(this.RestProducts_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelContenedor;
        private LineRestProducts lineRestProducts1;
    }
}
