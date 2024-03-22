namespace ClothCraze.Filtraje
{
	partial class FiltroMarca
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
            this.RadioAdidas = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioPuma = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioNike = new Guna.UI2.WinForms.Guna2RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRadios
            // 
            this.PanelRadios.BorderRadius = 10;
            this.PanelRadios.Controls.Add(this.RadioAdidas);
            this.PanelRadios.Controls.Add(this.RadioPuma);
            this.PanelRadios.Controls.Add(this.RadioNike);
            this.PanelRadios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.PanelRadios.FillColor2 = System.Drawing.Color.DarkGray;
            this.PanelRadios.Location = new System.Drawing.Point(5, 2);
            this.PanelRadios.Name = "PanelRadios";
            this.PanelRadios.Size = new System.Drawing.Size(200, 35);
            this.PanelRadios.TabIndex = 3;
            // 
            // RadioAdidas
            // 
            this.RadioAdidas.AutoSize = true;
            this.RadioAdidas.BackColor = System.Drawing.Color.Transparent;
            this.RadioAdidas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioAdidas.CheckedState.BorderThickness = 0;
            this.RadioAdidas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioAdidas.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioAdidas.CheckedState.InnerOffset = -4;
            this.RadioAdidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioAdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioAdidas.ForeColor = System.Drawing.Color.White;
            this.RadioAdidas.Location = new System.Drawing.Point(132, 10);
            this.RadioAdidas.Name = "RadioAdidas";
            this.RadioAdidas.Size = new System.Drawing.Size(63, 17);
            this.RadioAdidas.TabIndex = 2;
            this.RadioAdidas.Text = "Adidas";
            this.RadioAdidas.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioAdidas.UncheckedState.BorderThickness = 2;
            this.RadioAdidas.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioAdidas.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioAdidas.UseVisualStyleBackColor = false;
            this.RadioAdidas.CheckedChanged += new System.EventHandler(this.RadioAdidas_CheckedChanged);
            this.RadioAdidas.Click += new System.EventHandler(this.RadioAdidas_Click);
            // 
            // RadioPuma
            // 
            this.RadioPuma.AutoSize = true;
            this.RadioPuma.BackColor = System.Drawing.Color.Transparent;
            this.RadioPuma.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioPuma.CheckedState.BorderThickness = 0;
            this.RadioPuma.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioPuma.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioPuma.CheckedState.InnerOffset = -4;
            this.RadioPuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioPuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioPuma.ForeColor = System.Drawing.Color.White;
            this.RadioPuma.Location = new System.Drawing.Point(67, 9);
            this.RadioPuma.Name = "RadioPuma";
            this.RadioPuma.Size = new System.Drawing.Size(56, 17);
            this.RadioPuma.TabIndex = 1;
            this.RadioPuma.Text = "Puma";
            this.RadioPuma.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioPuma.UncheckedState.BorderThickness = 2;
            this.RadioPuma.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioPuma.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioPuma.UseVisualStyleBackColor = false;
            this.RadioPuma.CheckedChanged += new System.EventHandler(this.RadioPuma_CheckedChanged);
            this.RadioPuma.Click += new System.EventHandler(this.RadioPuma_Click);
            // 
            // RadioNike
            // 
            this.RadioNike.AutoSize = true;
            this.RadioNike.BackColor = System.Drawing.Color.Transparent;
            this.RadioNike.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNike.CheckedState.BorderThickness = 0;
            this.RadioNike.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNike.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioNike.CheckedState.InnerOffset = -4;
            this.RadioNike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioNike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioNike.ForeColor = System.Drawing.Color.White;
            this.RadioNike.Location = new System.Drawing.Point(2, 10);
            this.RadioNike.Name = "RadioNike";
            this.RadioNike.Size = new System.Drawing.Size(51, 17);
            this.RadioNike.TabIndex = 0;
            this.RadioNike.Text = "Nike";
            this.RadioNike.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioNike.UncheckedState.BorderThickness = 2;
            this.RadioNike.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioNike.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioNike.UseVisualStyleBackColor = false;
            this.RadioNike.CheckedChanged += new System.EventHandler(this.RadioNike_CheckedChanged);
            this.RadioNike.Click += new System.EventHandler(this.RadioNike_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FiltroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelRadios);
            this.Name = "FiltroMarca";
            this.Size = new System.Drawing.Size(211, 40);
            this.PanelRadios.ResumeLayout(false);
            this.PanelRadios.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel PanelRadios;
        private Guna.UI2.WinForms.Guna2RadioButton RadioAdidas;
        private Guna.UI2.WinForms.Guna2RadioButton RadioPuma;
        private Guna.UI2.WinForms.Guna2RadioButton RadioNike;
        private System.Windows.Forms.Timer timer1;
    }
}
