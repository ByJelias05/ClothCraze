namespace ClothCraze.Modales.Administraciones
{
    partial class LineRestProducts
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
            this.components = new System.ComponentModel.Container();
            this.BarraProgreso = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.LblVestimenta = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BarraProgreso.BorderRadius = 7;
            this.BarraProgreso.FillColor = System.Drawing.Color.Silver;
            this.BarraProgreso.Location = new System.Drawing.Point(43, 3);
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.BarraProgreso.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.BarraProgreso.ShadowDecoration.BorderRadius = 5;
            this.BarraProgreso.ShowText = true;
            this.BarraProgreso.Size = new System.Drawing.Size(23, 95);
            this.BarraProgreso.TabIndex = 0;
            this.BarraProgreso.Text = "500";
            this.BarraProgreso.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.BarraProgreso.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BarraProgreso.Value = 50;
            // 
            // LblVestimenta
            // 
            this.LblVestimenta.AutoSize = true;
            this.LblVestimenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblVestimenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVestimenta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblVestimenta.Location = new System.Drawing.Point(0, 107);
            this.LblVestimenta.Name = "LblVestimenta";
            this.LblVestimenta.Size = new System.Drawing.Size(104, 15);
            this.LblVestimenta.TabIndex = 1;
            this.LblVestimenta.Text = "Puma Sweater MD";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LineRestProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LblVestimenta);
            this.Controls.Add(this.BarraProgreso);
            this.Name = "LineRestProducts";
            this.Size = new System.Drawing.Size(104, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2VProgressBar BarraProgreso;
        private System.Windows.Forms.Label LblVestimenta;
        private System.Windows.Forms.Timer timer1;
    }
}
