namespace ClothCraze.Filtraje
{
	partial class FiltroColor
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
            this.RadioGris = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioNegro = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioBlanco = new Guna.UI2.WinForms.Guna2RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRadios
            // 
            this.PanelRadios.BorderRadius = 10;
            this.PanelRadios.Controls.Add(this.RadioGris);
            this.PanelRadios.Controls.Add(this.RadioNegro);
            this.PanelRadios.Controls.Add(this.RadioBlanco);
            this.PanelRadios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.PanelRadios.FillColor2 = System.Drawing.Color.DarkGray;
            this.PanelRadios.Location = new System.Drawing.Point(5, 2);
            this.PanelRadios.Name = "PanelRadios";
            this.PanelRadios.Size = new System.Drawing.Size(200, 35);
            this.PanelRadios.TabIndex = 3;
            // 
            // RadioGris
            // 
            this.RadioGris.AutoSize = true;
            this.RadioGris.BackColor = System.Drawing.Color.Transparent;
            this.RadioGris.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioGris.CheckedState.BorderThickness = 0;
            this.RadioGris.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioGris.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioGris.CheckedState.InnerOffset = -4;
            this.RadioGris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioGris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioGris.ForeColor = System.Drawing.Color.White;
            this.RadioGris.Location = new System.Drawing.Point(132, 10);
            this.RadioGris.Name = "RadioGris";
            this.RadioGris.Size = new System.Drawing.Size(51, 17);
            this.RadioGris.TabIndex = 2;
            this.RadioGris.Text = "Grey";
            this.RadioGris.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioGris.UncheckedState.BorderThickness = 2;
            this.RadioGris.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioGris.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioGris.UseVisualStyleBackColor = false;
            this.RadioGris.CheckedChanged += new System.EventHandler(this.RadioGris_CheckedChanged);
            this.RadioGris.Click += new System.EventHandler(this.RadioGris_Click);
            // 
            // RadioNegro
            // 
            this.RadioNegro.AutoSize = true;
            this.RadioNegro.BackColor = System.Drawing.Color.Transparent;
            this.RadioNegro.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNegro.CheckedState.BorderThickness = 0;
            this.RadioNegro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioNegro.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioNegro.CheckedState.InnerOffset = -4;
            this.RadioNegro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioNegro.ForeColor = System.Drawing.Color.White;
            this.RadioNegro.Location = new System.Drawing.Point(67, 9);
            this.RadioNegro.Name = "RadioNegro";
            this.RadioNegro.Size = new System.Drawing.Size(57, 17);
            this.RadioNegro.TabIndex = 1;
            this.RadioNegro.Text = "Black";
            this.RadioNegro.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioNegro.UncheckedState.BorderThickness = 2;
            this.RadioNegro.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioNegro.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioNegro.UseVisualStyleBackColor = false;
            this.RadioNegro.CheckedChanged += new System.EventHandler(this.RadioNegro_CheckedChanged);
            this.RadioNegro.Click += new System.EventHandler(this.RadioNegro_Click);
            // 
            // RadioBlanco
            // 
            this.RadioBlanco.AutoSize = true;
            this.RadioBlanco.BackColor = System.Drawing.Color.Transparent;
            this.RadioBlanco.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioBlanco.CheckedState.BorderThickness = 0;
            this.RadioBlanco.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.RadioBlanco.CheckedState.InnerColor = System.Drawing.Color.DimGray;
            this.RadioBlanco.CheckedState.InnerOffset = -4;
            this.RadioBlanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadioBlanco.ForeColor = System.Drawing.Color.White;
            this.RadioBlanco.Location = new System.Drawing.Point(2, 10);
            this.RadioBlanco.Name = "RadioBlanco";
            this.RadioBlanco.Size = new System.Drawing.Size(58, 17);
            this.RadioBlanco.TabIndex = 0;
            this.RadioBlanco.Text = "White";
            this.RadioBlanco.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RadioBlanco.UncheckedState.BorderThickness = 2;
            this.RadioBlanco.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.RadioBlanco.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioBlanco.UseVisualStyleBackColor = false;
            this.RadioBlanco.CheckedChanged += new System.EventHandler(this.RadioBlanco_CheckedChanged);
            this.RadioBlanco.Click += new System.EventHandler(this.RadioBlanco_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FiltroColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelRadios);
            this.Name = "FiltroColor";
            this.Size = new System.Drawing.Size(211, 40);
            this.PanelRadios.ResumeLayout(false);
            this.PanelRadios.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel PanelRadios;
		private Guna.UI2.WinForms.Guna2RadioButton RadioGris;
		private Guna.UI2.WinForms.Guna2RadioButton RadioNegro;
		private Guna.UI2.WinForms.Guna2RadioButton RadioBlanco;
        private System.Windows.Forms.Timer timer1;
    }
}
