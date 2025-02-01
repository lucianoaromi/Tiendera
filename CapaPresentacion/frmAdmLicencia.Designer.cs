using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmAdmLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmLicencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodactivacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboestado1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfechaverificacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiasPermitido = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtindicecliente = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasPermitidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActivacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoActivacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaVerificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod Activacion:";
            // 
            // txtcodactivacion
            // 
            this.txtcodactivacion.Location = new System.Drawing.Point(13, 229);
            this.txtcodactivacion.Name = "txtcodactivacion";
            this.txtcodactivacion.Size = new System.Drawing.Size(154, 20);
            this.txtcodactivacion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado:";
            // 
            // cboestado1
            // 
            this.cboestado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado1.FormattingEnabled = true;
            this.cboestado1.Location = new System.Drawing.Point(12, 132);
            this.cboestado1.Name = "cboestado1";
            this.cboestado1.Size = new System.Drawing.Size(155, 21);
            this.cboestado1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtfechaverificacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtfechainicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcodactivacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDiasPermitido);
            this.panel1.Controls.Add(this.cboestado1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtindicecliente);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnlimpiar);
            this.panel1.Controls.Add(this.txtidcliente);
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 396);
            this.panel1.TabIndex = 20;
            // 
            // txtfechaverificacion
            // 
            this.txtfechaverificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechaverificacion.Location = new System.Drawing.Point(12, 276);
            this.txtfechaverificacion.Name = "txtfechaverificacion";
            this.txtfechaverificacion.Size = new System.Drawing.Size(155, 20);
            this.txtfechaverificacion.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ultima Verificacion:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechainicio.Location = new System.Drawing.Point(12, 181);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(155, 20);
            this.txtfechainicio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha Activacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Dias Permitidos:";
            // 
            // txtDiasPermitido
            // 
            this.txtDiasPermitido.Location = new System.Drawing.Point(12, 85);
            this.txtDiasPermitido.Name = "txtDiasPermitido";
            this.txtDiasPermitido.Size = new System.Drawing.Size(155, 20);
            this.txtDiasPermitido.TabIndex = 45;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha.Location = new System.Drawing.Point(12, 40);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(155, 20);
            this.txtfecha.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha Inicio:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Black;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(12, 315);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(48, 48);
            this.btnguardar.TabIndex = 39;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // txtindicecliente
            // 
            this.txtindicecliente.BackColor = System.Drawing.Color.White;
            this.txtindicecliente.ForeColor = System.Drawing.Color.Black;
            this.txtindicecliente.Location = new System.Drawing.Point(108, 6);
            this.txtindicecliente.Name = "txtindicecliente";
            this.txtindicecliente.Size = new System.Drawing.Size(30, 20);
            this.txtindicecliente.TabIndex = 34;
            this.txtindicecliente.Text = "-1";
            this.txtindicecliente.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Black;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(119, 315);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(48, 48);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(65, 315);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(48, 48);
            this.btnlimpiar.TabIndex = 37;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.BackColor = System.Drawing.Color.White;
            this.txtidcliente.ForeColor = System.Drawing.Color.Black;
            this.txtidcliente.Location = new System.Drawing.Point(146, 6);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(31, 20);
            this.txtidcliente.TabIndex = 33;
            this.txtidcliente.Text = "0";
            this.txtidcliente.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.BackColor = System.Drawing.Color.DimGray;
            this.txtindice.Location = new System.Drawing.Point(162, 14);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(1, 20);
            this.txtindice.TabIndex = 1;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.DimGray;
            this.txtid.Location = new System.Drawing.Point(191, 14);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(1, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 60);
            this.panel2.TabIndex = 27;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.No;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.Gold;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 20;
            this.btncancelar.Location = new System.Drawing.Point(664, 16);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(30, 28);
            this.btncancelar.TabIndex = 30;
            this.btncancelar.Text = "X";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Licencia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvdata);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(183, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 336);
            this.panel3.TabIndex = 28;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.ID,
            this.FechaInicio,
            this.DiasPermitidos,
            this.Activado,
            this.EstadoValor,
            this.FechaActivacion,
            this.CodigoActivacion,
            this.UltimaVerificacion});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.Location = new System.Drawing.Point(0, 0);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(712, 336);
            this.dgvdata.TabIndex = 22;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick_1);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // DiasPermitidos
            // 
            this.DiasPermitidos.HeaderText = "DiasPermitidos";
            this.DiasPermitidos.Name = "DiasPermitidos";
            this.DiasPermitidos.ReadOnly = true;
            // 
            // Activado
            // 
            this.Activado.HeaderText = "Estado";
            this.Activado.MinimumWidth = 6;
            this.Activado.Name = "Activado";
            this.Activado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // FechaActivacion
            // 
            this.FechaActivacion.HeaderText = "Fecha Activacion";
            this.FechaActivacion.Name = "FechaActivacion";
            this.FechaActivacion.ReadOnly = true;
            // 
            // CodigoActivacion
            // 
            this.CodigoActivacion.HeaderText = "Codigo Activacion";
            this.CodigoActivacion.MinimumWidth = 6;
            this.CodigoActivacion.Name = "CodigoActivacion";
            this.CodigoActivacion.ReadOnly = true;
            // 
            // UltimaVerificacion
            // 
            this.UltimaVerificacion.HeaderText = "UltimaVerificacion";
            this.UltimaVerificacion.Name = "UltimaVerificacion";
            this.UltimaVerificacion.ReadOnly = true;
            this.UltimaVerificacion.Width = 115;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdmLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(895, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodactivacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboestado1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtindicecliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private Label label9;
        private DateTimePicker txtfecha;
        private TextBox txtDiasPermitido;
        private Label label1;
        private DateTimePicker txtfechainicio;
        private Label label3;
        private FontAwesome.Sharp.IconButton btncancelar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn DiasPermitidos;
        private DataGridViewTextBoxColumn Activado;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn FechaActivacion;
        private DataGridViewTextBoxColumn CodigoActivacion;
        private DataGridViewTextBoxColumn UltimaVerificacion;
        private DateTimePicker txtfechaverificacion;
        private Label label4;
        private PictureBox pictureBox1;
    }
}