namespace CapaPresentacion
{
    partial class frmGraficos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficos));
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOkCustomDate = new FontAwesome.Sharp.IconButton();
            this.btnCustomDate = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(582, 114);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(109, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(704, 114);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(109, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(21, 16);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(67, 25);
            this.lblTotalProfit.TabIndex = 9;
            this.lblTotalProfit.Text = "10000";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chartGrossRevenue.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartGrossRevenue.BackSecondaryColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea9.BackImageTransparentColor = System.Drawing.Color.IndianRed;
            chartArea9.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea9.BackSecondaryColor = System.Drawing.Color.IndianRed;
            chartArea9.BorderColor = System.Drawing.Color.IndianRed;
            chartArea9.CursorX.LineColor = System.Drawing.Color.White;
            chartArea9.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea9.CursorY.LineColor = System.Drawing.Color.White;
            chartArea9.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            chartArea9.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.chartGrossRevenue.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.DarkSlateGray;
            legend9.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            legend9.BackSecondaryColor = System.Drawing.Color.Brown;
            legend9.BorderColor = System.Drawing.Color.WhiteSmoke;
            legend9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.HeaderSeparatorColor = System.Drawing.Color.White;
            legend9.InterlacedRowsColor = System.Drawing.Color.White;
            legend9.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            legend9.ShadowColor = System.Drawing.Color.White;
            legend9.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend9.TitleBackColor = System.Drawing.Color.White;
            legend9.TitleForeColor = System.Drawing.Color.White;
            legend9.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartGrossRevenue.Legends.Add(legend9);
            this.chartGrossRevenue.Location = new System.Drawing.Point(2, 20);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series9.BackImageTransparentColor = System.Drawing.Color.White;
            series9.BackSecondaryColor = System.Drawing.Color.White;
            series9.ChartArea = "ChartArea1";
            series9.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.Color = System.Drawing.Color.White;
            series9.EmptyPointStyle.LabelBackColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series9.EmptyPointStyle.MarkerColor = System.Drawing.Color.White;
            series9.LabelBackColor = System.Drawing.Color.White;
            series9.LabelBorderColor = System.Drawing.Color.White;
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.MarkerBorderColor = System.Drawing.Color.White;
            series9.MarkerColor = System.Drawing.Color.White;
            series9.Name = "Pesos $";
            series9.ShadowColor = System.Drawing.Color.White;
            series9.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series9.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chartGrossRevenue.Series.Add(series9);
            this.chartGrossRevenue.Size = new System.Drawing.Size(493, 187);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "chart1";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chartTopProducts.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartTopProducts.BackSecondaryColor = System.Drawing.Color.White;
            this.chartTopProducts.BorderlineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea10.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea10.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea10.BackSecondaryColor = System.Drawing.Color.White;
            chartArea10.BorderColor = System.Drawing.Color.White;
            chartArea10.Name = "ChartArea1";
            chartArea10.ShadowColor = System.Drawing.Color.Red;
            this.chartTopProducts.ChartAreas.Add(chartArea10);
            this.chartTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.BackColor = System.Drawing.Color.DarkSlateGray;
            legend10.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend10.BackSecondaryColor = System.Drawing.Color.DarkSlateGray;
            legend10.BorderColor = System.Drawing.Color.Transparent;
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend10.ForeColor = System.Drawing.Color.White;
            legend10.HeaderSeparatorColor = System.Drawing.Color.DarkSlateGray;
            legend10.InterlacedRowsColor = System.Drawing.Color.Black;
            legend10.IsEquallySpacedItems = true;
            legend10.ItemColumnSeparatorColor = System.Drawing.Color.DarkSlateGray;
            legend10.Name = "Legend1";
            legend10.ShadowColor = System.Drawing.Color.DarkOrange;
            legend10.TitleBackColor = System.Drawing.Color.DarkSlateGray;
            legend10.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend10.TitleForeColor = System.Drawing.Color.DarkSlateGray;
            legend10.TitleSeparatorColor = System.Drawing.Color.Chocolate;
            this.chartTopProducts.Legends.Add(legend10);
            this.chartTopProducts.Location = new System.Drawing.Point(3, 16);
            this.chartTopProducts.Name = "chartTopProducts";
            series10.BackImageTransparentColor = System.Drawing.Color.IndianRed;
            series10.BackSecondaryColor = System.Drawing.Color.IndianRed;
            series10.BorderColor = System.Drawing.Color.Transparent;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series10.Color = System.Drawing.Color.Black;
            series10.CustomProperties = "PieLineColor=DimGray, CollectedColor=64\\, 64\\, 64";
            series10.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.CustomProperties = "PieLineColor=64\\, 64\\, 64";
            series10.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series10.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series10.IsValueShownAsLabel = true;
            series10.LabelBackColor = System.Drawing.Color.Transparent;
            series10.LabelBorderColor = System.Drawing.Color.Transparent;
            series10.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series10.LabelForeColor = System.Drawing.Color.White;
            series10.Legend = "Legend1";
            series10.MarkerBorderColor = System.Drawing.Color.Black;
            series10.MarkerColor = System.Drawing.Color.Black;
            series10.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series10.Name = "Series1";
            series10.ShadowColor = System.Drawing.Color.RosyBrown;
            this.chartTopProducts.Series.Add(series10);
            this.chartTopProducts.Size = new System.Drawing.Size(383, 436);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chart2";
            title5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title5.ForeColor = System.Drawing.Color.White;
            title5.Name = "Title1";
            title5.Text = "Top 5 Productos";
            this.chartTopProducts.Titles.Add(title5);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Productos Diferentes";
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.ForeColor = System.Drawing.Color.White;
            this.lblNumProducts.Location = new System.Drawing.Point(21, 126);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(67, 25);
            this.lblNumProducts.TabIndex = 11;
            this.lblNumProducts.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numero de Clientes";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.ForeColor = System.Drawing.Color.White;
            this.lblNumCustomers.Location = new System.Drawing.Point(21, 64);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(67, 25);
            this.lblNumCustomers.TabIndex = 9;
            this.lblNumCustomers.Text = "10000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gold;
            this.label14.Location = new System.Drawing.Point(24, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "Estadisticas";
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AllowUserToAddRows = false;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(5, 18);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.ReadOnly = true;
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.Size = new System.Drawing.Size(382, 203);
            this.dgvUnderstock.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.groupBox7);
            this.panel6.Controls.Add(this.dtpEndDate);
            this.panel6.Controls.Add(this.dtpStartDate);
            this.panel6.Controls.Add(this.groupBox6);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.btnOkCustomDate);
            this.panel6.Controls.Add(this.btnCustomDate);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(13, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1004, 618);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(688, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(592, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(781, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chartTopProducts);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(583, 142);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(389, 455);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblNumOrders);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(32, 74);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 49);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad de Ventas";
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(10, 16);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(67, 25);
            this.lblNumOrders.TabIndex = 9;
            this.lblNumOrders.Text = "10000";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalRevenue);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(152, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 49);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingresos Totales";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(10, 16);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(67, 25);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "10000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalProfit);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(318, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 49);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ganancias Totales";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkCustomDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOkCustomDate.IconColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOkCustomDate.Location = new System.Drawing.Point(820, 110);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(50, 28);
            this.btnOkCustomDate.TabIndex = 24;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click_1);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCustomDate.IconColor = System.Drawing.Color.Black;
            this.btnCustomDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomDate.Location = new System.Drawing.Point(877, 110);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(96, 28);
            this.btnCustomDate.TabIndex = 19;
            this.btnCustomDate.Text = "Periodos";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblNumCustomers);
            this.groupBox3.Controls.Add(this.lblNumProducts);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(31, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 227);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contador Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUnderstock);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(164, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 227);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos de bajo stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartGrossRevenue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(30, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 212);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos brutos";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 640);
            this.panel2.TabIndex = 19;
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 640);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnOkCustomDate;
        private FontAwesome.Sharp.IconButton btnCustomDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}