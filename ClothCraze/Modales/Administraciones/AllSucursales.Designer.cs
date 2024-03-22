namespace ClothCraze.Modales.Administraciones
{
    partial class AllSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSucursales));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSend = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtLongitude = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtLatitude = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelContenedorSucursales = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmbBranch = new Bunifu.UI.WinForms.BunifuDropdown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblid = new System.Windows.Forms.Label();
            this.CheckAgregarSucursal = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(901, 375);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.bunifuLabel1);
            this.guna2Panel3.Controls.Add(this.CheckAgregarSucursal);
            this.guna2Panel3.Controls.Add(this.lblid);
            this.guna2Panel3.Controls.Add(this.CmbBranch);
            this.guna2Panel3.Controls.Add(this.BtnSend);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.TxtCity);
            this.guna2Panel3.Controls.Add(this.TxtCountry);
            this.guna2Panel3.Controls.Add(this.TxtLongitude);
            this.guna2Panel3.Controls.Add(this.TxtLatitude);
            this.guna2Panel3.Location = new System.Drawing.Point(529, 34);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(340, 304);
            this.guna2Panel3.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(79, 244);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(180, 45);
            this.BtnSend.TabIndex = 10;
            this.BtnSend.Text = "Send";
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(15, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Branch of";
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCity.BorderRadius = 15;
            this.TxtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCity.DefaultText = "";
            this.TxtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCity.FillColor = System.Drawing.Color.Silver;
            this.TxtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCity.Location = new System.Drawing.Point(179, 40);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.PasswordChar = '\0';
            this.TxtCity.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtCity.PlaceholderText = "City";
            this.TxtCity.SelectedText = "";
            this.TxtCity.Size = new System.Drawing.Size(158, 36);
            this.TxtCity.TabIndex = 8;
            // 
            // TxtCountry
            // 
            this.TxtCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCountry.BorderRadius = 15;
            this.TxtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCountry.DefaultText = "";
            this.TxtCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCountry.FillColor = System.Drawing.Color.Silver;
            this.TxtCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCountry.Location = new System.Drawing.Point(3, 40);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.PasswordChar = '\0';
            this.TxtCountry.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtCountry.PlaceholderText = "Country";
            this.TxtCountry.SelectedText = "";
            this.TxtCountry.Size = new System.Drawing.Size(158, 36);
            this.TxtCountry.TabIndex = 7;
            // 
            // TxtLongitude
            // 
            this.TxtLongitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtLongitude.BorderRadius = 15;
            this.TxtLongitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLongitude.DefaultText = "";
            this.TxtLongitude.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtLongitude.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtLongitude.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLongitude.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLongitude.FillColor = System.Drawing.Color.Silver;
            this.TxtLongitude.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLongitude.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtLongitude.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLongitude.Location = new System.Drawing.Point(179, 177);
            this.TxtLongitude.Name = "TxtLongitude";
            this.TxtLongitude.PasswordChar = '\0';
            this.TxtLongitude.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtLongitude.PlaceholderText = "Longitude";
            this.TxtLongitude.SelectedText = "";
            this.TxtLongitude.Size = new System.Drawing.Size(158, 36);
            this.TxtLongitude.TabIndex = 6;
            // 
            // TxtLatitude
            // 
            this.TxtLatitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtLatitude.BorderRadius = 15;
            this.TxtLatitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLatitude.DefaultText = "";
            this.TxtLatitude.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtLatitude.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtLatitude.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLatitude.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLatitude.FillColor = System.Drawing.Color.Silver;
            this.TxtLatitude.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLatitude.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtLatitude.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLatitude.Location = new System.Drawing.Point(3, 177);
            this.TxtLatitude.Name = "TxtLatitude";
            this.TxtLatitude.PasswordChar = '\0';
            this.TxtLatitude.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtLatitude.PlaceholderText = "Latitude";
            this.TxtLatitude.SelectedText = "";
            this.TxtLatitude.Size = new System.Drawing.Size(158, 36);
            this.TxtLatitude.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.Controls.Add(this.PanelContenedorSucursales);
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.Silver;
            this.guna2Panel2.Location = new System.Drawing.Point(26, 34);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(461, 304);
            this.guna2Panel2.TabIndex = 0;
            // 
            // PanelContenedorSucursales
            // 
            this.PanelContenedorSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorSucursales.Location = new System.Drawing.Point(0, 58);
            this.PanelContenedorSucursales.Name = "PanelContenedorSucursales";
            this.PanelContenedorSucursales.Size = new System.Drawing.Size(461, 246);
            this.PanelContenedorSucursales.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(231, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 58);
            this.label6.TabIndex = 6;
            this.label6.Text = "Longitude";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(307, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 58);
            this.label5.TabIndex = 5;
            this.label5.Text = "Latitude";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(383, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 58);
            this.label4.TabIndex = 4;
            this.label4.Text = "Accion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 58);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(79, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch of";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmbBranch
            // 
            this.CmbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBranch.BackColor = System.Drawing.Color.Transparent;
            this.CmbBranch.BackgroundColor = System.Drawing.Color.Silver;
            this.CmbBranch.BorderColor = System.Drawing.Color.Silver;
            this.CmbBranch.BorderRadius = 15;
            this.CmbBranch.Color = System.Drawing.Color.Silver;
            this.CmbBranch.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CmbBranch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CmbBranch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CmbBranch.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CmbBranch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CmbBranch.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CmbBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBranch.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.CmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBranch.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CmbBranch.FillDropDown = true;
            this.CmbBranch.FillIndicator = false;
            this.CmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBranch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmbBranch.ForeColor = System.Drawing.Color.DimGray;
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Icon = null;
            this.CmbBranch.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CmbBranch.IndicatorColor = System.Drawing.Color.DarkGray;
            this.CmbBranch.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CmbBranch.IndicatorThickness = 2;
            this.CmbBranch.IsDropdownOpened = false;
            this.CmbBranch.ItemBackColor = System.Drawing.Color.White;
            this.CmbBranch.ItemBorderColor = System.Drawing.Color.White;
            this.CmbBranch.ItemForeColor = System.Drawing.Color.Black;
            this.CmbBranch.ItemHeight = 26;
            this.CmbBranch.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.CmbBranch.ItemHighLightForeColor = System.Drawing.Color.White;
            this.CmbBranch.Items.AddRange(new object[] {
            "Principal",
            "Reception",
            "Physical Store"});
            this.CmbBranch.ItemTopMargin = 3;
            this.CmbBranch.Location = new System.Drawing.Point(3, 111);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(334, 32);
            this.CmbBranch.TabIndex = 1;
            this.CmbBranch.Text = "Branch";
            this.CmbBranch.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CmbBranch.TextLeftMargin = 5;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(57, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 11;
            // 
            // CheckAgregarSucursal
            // 
            this.CheckAgregarSucursal.AllowBindingControlAnimation = true;
            this.CheckAgregarSucursal.AllowBindingControlColorChanges = false;
            this.CheckAgregarSucursal.AllowBindingControlLocation = true;
            this.CheckAgregarSucursal.AllowCheckBoxAnimation = false;
            this.CheckAgregarSucursal.AllowCheckmarkAnimation = true;
            this.CheckAgregarSucursal.AllowOnHoverStates = true;
            this.CheckAgregarSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckAgregarSucursal.AutoCheck = true;
            this.CheckAgregarSucursal.BackColor = System.Drawing.Color.Transparent;
            this.CheckAgregarSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckAgregarSucursal.BackgroundImage")));
            this.CheckAgregarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckAgregarSucursal.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckAgregarSucursal.BorderRadius = 12;
            this.CheckAgregarSucursal.Checked = false;
            this.CheckAgregarSucursal.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckAgregarSucursal.CustomCheckmarkImage = null;
            this.CheckAgregarSucursal.Location = new System.Drawing.Point(7, 7);
            this.CheckAgregarSucursal.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckAgregarSucursal.Name = "CheckAgregarSucursal";
            this.CheckAgregarSucursal.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckAgregarSucursal.OnCheck.BorderRadius = 12;
            this.CheckAgregarSucursal.OnCheck.BorderThickness = 2;
            this.CheckAgregarSucursal.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckAgregarSucursal.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckAgregarSucursal.OnCheck.CheckmarkThickness = 2;
            this.CheckAgregarSucursal.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckAgregarSucursal.OnDisable.BorderRadius = 12;
            this.CheckAgregarSucursal.OnDisable.BorderThickness = 2;
            this.CheckAgregarSucursal.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckAgregarSucursal.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckAgregarSucursal.OnDisable.CheckmarkThickness = 2;
            this.CheckAgregarSucursal.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckAgregarSucursal.OnHoverChecked.BorderRadius = 12;
            this.CheckAgregarSucursal.OnHoverChecked.BorderThickness = 2;
            this.CheckAgregarSucursal.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckAgregarSucursal.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckAgregarSucursal.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckAgregarSucursal.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckAgregarSucursal.OnHoverUnchecked.BorderRadius = 12;
            this.CheckAgregarSucursal.OnHoverUnchecked.BorderThickness = 1;
            this.CheckAgregarSucursal.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckAgregarSucursal.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckAgregarSucursal.OnUncheck.BorderRadius = 12;
            this.CheckAgregarSucursal.OnUncheck.BorderThickness = 1;
            this.CheckAgregarSucursal.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckAgregarSucursal.Size = new System.Drawing.Size(21, 21);
            this.CheckAgregarSucursal.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckAgregarSucursal.TabIndex = 12;
            this.CheckAgregarSucursal.ThreeState = false;
            this.CheckAgregarSucursal.ToolTipText = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(34, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(99, 15);
            this.bunifuLabel1.TabIndex = 13;
            this.bunifuLabel1.Text = "Add a new branch";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // AllSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AllSucursales";
            this.Size = new System.Drawing.Size(901, 375);
            this.Load += new System.EventHandler(this.AllSucursales_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel PanelContenedorSucursales;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox TxtLongitude;
        private Guna.UI2.WinForms.Guna2TextBox TxtLatitude;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TxtCity;
        private Guna.UI2.WinForms.Guna2TextBox TxtCountry;
        private Guna.UI2.WinForms.Guna2Button BtnSend;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuDropdown CmbBranch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblid;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckAgregarSucursal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
