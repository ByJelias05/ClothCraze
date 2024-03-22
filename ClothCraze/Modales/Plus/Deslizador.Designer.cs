namespace ClothCraze.Modales.Plus
{
    partial class Deslizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deslizador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVer = new System.Windows.Forms.PictureBox();
            this.BtnNoVer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNoVer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVer.Image = ((System.Drawing.Image)(resources.GetObject("BtnVer.Image")));
            this.BtnVer.Location = new System.Drawing.Point(3, 37);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(30, 45);
            this.BtnVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVer.TabIndex = 1;
            this.BtnVer.TabStop = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnNoVer
            // 
            this.BtnNoVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNoVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnNoVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNoVer.Image = ((System.Drawing.Image)(resources.GetObject("BtnNoVer.Image")));
            this.BtnNoVer.Location = new System.Drawing.Point(3, 37);
            this.BtnNoVer.Name = "BtnNoVer";
            this.BtnNoVer.Size = new System.Drawing.Size(30, 45);
            this.BtnNoVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNoVer.TabIndex = 2;
            this.BtnNoVer.TabStop = false;
            this.BtnNoVer.Visible = false;
            this.BtnNoVer.Click += new System.EventHandler(this.BtnNoVer_Click);
            // 
            // Deslizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BtnNoVer);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Deslizador";
            this.Size = new System.Drawing.Size(34, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNoVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnVer;
        private System.Windows.Forms.PictureBox BtnNoVer;
    }
}
