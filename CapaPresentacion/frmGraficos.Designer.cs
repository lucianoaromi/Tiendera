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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new FontAwesome.Sharp.IconButton();
            this.btnCustomDate = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenue2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(661, 124);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(794, 124);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(125, 22);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(29, 212);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(24, 7);
            this.lblTotalProfit.TabIndex = 9;
            this.lblTotalProfit.Text = "10000";
            this.lblTotalProfit.Visible = false;
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.chartGrossRevenue.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartGrossRevenue.BackSecondaryColor = System.Drawing.Color.White;
            chartArea11.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea11.BackImageTransparentColor = System.Drawing.Color.IndianRed;
            chartArea11.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea11.BackSecondaryColor = System.Drawing.Color.IndianRed;
            chartArea11.BorderColor = System.Drawing.Color.IndianRed;
            chartArea11.CursorX.LineColor = System.Drawing.Color.White;
            chartArea11.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea11.CursorY.LineColor = System.Drawing.Color.White;
            chartArea11.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea11.Name = "ChartArea1";
            chartArea11.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.chartGrossRevenue.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.DarkSlateGray;
            legend11.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            legend11.BackSecondaryColor = System.Drawing.Color.Brown;
            legend11.BorderColor = System.Drawing.Color.WhiteSmoke;
            legend11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend11.ForeColor = System.Drawing.Color.White;
            legend11.HeaderSeparatorColor = System.Drawing.Color.White;
            legend11.InterlacedRowsColor = System.Drawing.Color.White;
            legend11.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend11.Name = "Legend1";
            legend11.ShadowColor = System.Drawing.Color.White;
            legend11.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend11.TitleBackColor = System.Drawing.Color.White;
            legend11.TitleForeColor = System.Drawing.Color.White;
            legend11.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartGrossRevenue.Legends.Add(legend11);
            this.chartGrossRevenue.Location = new System.Drawing.Point(8, 19);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series11.BackImageTransparentColor = System.Drawing.Color.White;
            series11.BackSecondaryColor = System.Drawing.Color.White;
            series11.ChartArea = "ChartArea1";
            series11.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.Color = System.Drawing.Color.White;
            series11.EmptyPointStyle.LabelBackColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series11.EmptyPointStyle.MarkerColor = System.Drawing.Color.White;
            series11.LabelBackColor = System.Drawing.Color.White;
            series11.LabelBorderColor = System.Drawing.Color.White;
            series11.LabelForeColor = System.Drawing.Color.White;
            series11.Legend = "Legend1";
            series11.MarkerBorderColor = System.Drawing.Color.White;
            series11.MarkerColor = System.Drawing.Color.White;
            series11.Name = "Pesos $";
            series11.ShadowColor = System.Drawing.Color.White;
            series11.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series11.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chartGrossRevenue.Series.Add(series11);
            this.chartGrossRevenue.Size = new System.Drawing.Size(539, 187);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "chart1";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.chartTopProducts.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartTopProducts.BackSecondaryColor = System.Drawing.Color.White;
            this.chartTopProducts.BorderlineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea12.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea12.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea12.BackSecondaryColor = System.Drawing.Color.White;
            chartArea12.BorderColor = System.Drawing.Color.White;
            chartArea12.Name = "ChartArea1";
            chartArea12.ShadowColor = System.Drawing.Color.Red;
            this.chartTopProducts.ChartAreas.Add(chartArea12);
            this.chartTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.BackColor = System.Drawing.Color.DarkSlateGray;
            legend12.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend12.BackSecondaryColor = System.Drawing.Color.DarkSlateGray;
            legend12.BorderColor = System.Drawing.Color.Transparent;
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.ForeColor = System.Drawing.Color.White;
            legend12.HeaderSeparatorColor = System.Drawing.Color.DarkSlateGray;
            legend12.InterlacedRowsColor = System.Drawing.Color.Black;
            legend12.IsEquallySpacedItems = true;
            legend12.ItemColumnSeparatorColor = System.Drawing.Color.DarkSlateGray;
            legend12.Name = "Legend1";
            legend12.ShadowColor = System.Drawing.Color.DarkOrange;
            legend12.TitleBackColor = System.Drawing.Color.DarkSlateGray;
            legend12.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend12.TitleForeColor = System.Drawing.Color.DarkSlateGray;
            legend12.TitleSeparatorColor = System.Drawing.Color.Chocolate;
            this.chartTopProducts.Legends.Add(legend12);
            this.chartTopProducts.Location = new System.Drawing.Point(3, 16);
            this.chartTopProducts.Name = "chartTopProducts";
            series12.BackImageTransparentColor = System.Drawing.Color.IndianRed;
            series12.BackSecondaryColor = System.Drawing.Color.IndianRed;
            series12.BorderColor = System.Drawing.Color.Transparent;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Color = System.Drawing.Color.Black;
            series12.CustomProperties = "PieLineColor=DimGray, CollectedColor=64\\, 64\\, 64";
            series12.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.CustomProperties = "PieLineColor=64\\, 64\\, 64";
            series12.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series12.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series12.IsValueShownAsLabel = true;
            series12.LabelBackColor = System.Drawing.Color.Transparent;
            series12.LabelBorderColor = System.Drawing.Color.Transparent;
            series12.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.MarkerBorderColor = System.Drawing.Color.Black;
            series12.MarkerColor = System.Drawing.Color.Black;
            series12.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series12.Name = "Series1";
            series12.ShadowColor = System.Drawing.Color.RosyBrown;
            this.chartTopProducts.Series.Add(series12);
            this.chartTopProducts.Size = new System.Drawing.Size(383, 436);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chart2";
            title6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title6.ForeColor = System.Drawing.Color.White;
            title6.Name = "Title1";
            title6.Text = "Top 5 Productos";
            this.chartTopProducts.Titles.Add(title6);
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
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gold;
            this.label14.Location = new System.Drawing.Point(155, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 31);
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
            this.dgvUnderstock.Size = new System.Drawing.Size(408, 203);
            this.dgvUnderstock.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.panel6.Controls.Add(this.groupBox8);
            this.panel6.Controls.Add(this.groupBox2);
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
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(16, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1153, 631);
            this.panel6.TabIndex = 18;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txtPorcentaje);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(404, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(180, 50);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Porcentaje de ganancias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ingrese porcentaje:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(111, 21);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(38, 22);
            this.txtPorcentaje.TabIndex = 59;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartGrossRevenue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(92, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 209);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos brutos";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 23);
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
            this.pictureBox3.Location = new System.Drawing.Point(671, 23);
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
            this.pictureBox1.Location = new System.Drawing.Point(956, 23);
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
            this.pictureBox4.Location = new System.Drawing.Point(860, 23);
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
            this.groupBox7.Location = new System.Drawing.Point(662, 152);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(389, 455);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblNumOrders);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(92, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(117, 50);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad de Ventas";
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(4, 16);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(67, 25);
            this.lblNumOrders.TabIndex = 9;
            this.lblNumOrders.Text = "10000";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalRevenue);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(217, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 50);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingresos Totales";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(4, 16);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(67, 25);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "10000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(404, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 50);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ganancias Totales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "10000";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkCustomDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOkCustomDate.IconColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOkCustomDate.Location = new System.Drawing.Point(927, 120);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(40, 28);
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
            this.btnCustomDate.Location = new System.Drawing.Point(973, 120);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(79, 28);
            this.btnCustomDate.TabIndex = 19;
            this.btnCustomDate.Text = "Periodos";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalRevenue2);
            this.groupBox3.Controls.Add(this.lblTotalProfit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblNumCustomers);
            this.groupBox3.Controls.Add(this.txtValor1);
            this.groupBox3.Controls.Add(this.lblNumProducts);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(92, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 227);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contador Total";
            // 
            // lblTotalRevenue2
            // 
            this.lblTotalRevenue2.AutoSize = true;
            this.lblTotalRevenue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue2.Location = new System.Drawing.Point(59, 212);
            this.lblTotalRevenue2.Name = "lblTotalRevenue2";
            this.lblTotalRevenue2.Size = new System.Drawing.Size(24, 7);
            this.lblTotalRevenue2.TabIndex = 60;
            this.lblTotalRevenue2.Text = "10000";
            this.lblTotalRevenue2.Visible = false;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(6, 201);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(17, 20);
            this.txtValor1.TabIndex = 58;
            this.txtValor1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUnderstock);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(226, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 227);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos de bajo stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 650);
            this.panel2.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 650);
            this.panel5.TabIndex = 66;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.Location = new System.Drawing.Point(162, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "-1";
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DimGray;
            this.textBox4.Location = new System.Drawing.Point(191, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "0";
            this.textBox4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 650);
            this.panel1.TabIndex = 67;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DimGray;
            this.textBox5.Location = new System.Drawing.Point(162, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "-1";
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DimGray;
            this.textBox6.Location = new System.Drawing.Point(191, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(1, 20);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "0";
            this.textBox6.Visible = false;
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 650);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRevenue2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}