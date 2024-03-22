namespace ClothCraze.Modales.ModalCompras
{
    partial class ProductSent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSent));
            this.lblVestimeta = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.SuspendLayout();
            // 
            // lblVestimeta
            // 
            this.lblVestimeta.AllowParentOverrides = false;
            this.lblVestimeta.AutoEllipsis = false;
            this.lblVestimeta.AutoSize = false;
            this.lblVestimeta.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVestimeta.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblVestimeta.Font = new System.Drawing.Font("Bebas", 9.749999F);
            this.lblVestimeta.ForeColor = System.Drawing.Color.White;
            this.lblVestimeta.Location = new System.Drawing.Point(1, 0);
            this.lblVestimeta.Name = "lblVestimeta";
            this.lblVestimeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVestimeta.Size = new System.Drawing.Size(94, 14);
            this.lblVestimeta.TabIndex = 23;
            this.lblVestimeta.Text = "Puma Sweater MD";
            this.lblVestimeta.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVestimeta.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 15);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(95, 10);
            this.bunifuSeparator1.TabIndex = 24;
            // 
            // ProductSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblVestimeta);
            this.Name = "ProductSent";
            this.Size = new System.Drawing.Size(95, 25);
            this.Load += new System.EventHandler(this.ProductSent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblVestimeta;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}
