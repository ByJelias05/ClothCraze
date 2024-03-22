namespace ClothCraze.Filtraje
{
	partial class FiltroSize
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
            this.PanelRadios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.RadioAdulto = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioNiño = new Guna.UI2.WinForms.Guna2RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRadios
            // 
            this.PanelRadios.BorderRadius = 10;
            this.PanelRadios.Controls.Add(this.RadioAdulto);
            this.PanelRadios.Controls.Add(this.RadioNiño);
            this.PanelRadios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.PanelRadios.FillColor2 = System.Drawing.Color.DarkGray;
            this.PanelRadios.Location = new System.Drawing.Point(5, 2);
            this.PanelRadios.Name = "PanelRadios";
            this.PanelRadios.Size = new System.Drawing.Size(200, 35);
            this.PanelRadios.TabIndex = 3;
            // 
            // RadioAdulto
            // 
            this.RadioAdulto.AutoSize = true;
            this.RadioAdulto.BackColor = System.Drawing.Color.Transparent;
            this.RadioAdulto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioAdulto.CheckedState.BorderThickness = 0;
            this.RadioAdulto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioAdulto.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioAdulto.CheckedState.InnerOffset = -4;
            this.RadioAdulto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioAdulto.ForeColor = System.Drawing.Color.White;
            this.RadioAdulto.Location = new System.Drawing.Point(130, 9);
            this.RadioAdulto.Name = "RadioAdulto";
            this.RadioAdulto.Size = new System.Drawing.Size(54, 17);
            this.RadioAdulto.TabIndex = 1;
            this.RadioAdulto.Text = "Adult";
            this.RadioAdulto.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioAdulto.UncheckedState.BorderThickness = 2;
            this.RadioAdulto.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioAdulto.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioAdulto.UseVisualStyleBackColor = false;
            this.RadioAdulto.CheckedChanged += new System.EventHandler(this.RadioAdulto_CheckedChanged);
            this.RadioAdulto.Click += new System.EventHandler(this.RadioAdulto_Click);
            // 
            // RadioNiño
            // 
            this.RadioNiño.AutoSize = true;
            this.RadioNiño.BackColor = System.Drawing.Color.Transparent;
            this.RadioNiño.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNiño.CheckedState.BorderThickness = 0;
            this.RadioNiño.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNiño.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioNiño.CheckedState.InnerOffset = -4;
            this.RadioNiño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioNiño.ForeColor = System.Drawing.Color.White;
            this.RadioNiño.Location = new System.Drawing.Point(12, 10);
            this.RadioNiño.Name = "RadioNiño";
            this.RadioNiño.Size = new System.Drawing.Size(43, 17);
            this.RadioNiño.TabIndex = 0;
            this.RadioNiño.Text = "Kid";
            this.RadioNiño.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioNiño.UncheckedState.BorderThickness = 2;
            this.RadioNiño.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioNiño.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioNiño.UseVisualStyleBackColor = false;
            this.RadioNiño.CheckedChanged += new System.EventHandler(this.RadioNiño_CheckedChanged);
            this.RadioNiño.Click += new System.EventHandler(this.RadioNiño_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FiltroSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelRadios);
            this.Name = "FiltroSize";
            this.Size = new System.Drawing.Size(211, 40);
            this.PanelRadios.ResumeLayout(false);
            this.PanelRadios.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel PanelRadios;
		private Guna.UI2.WinForms.Guna2RadioButton RadioAdulto;
		private Guna.UI2.WinForms.Guna2RadioButton RadioNiño;
        private System.Windows.Forms.Timer timer1;
    }
}
