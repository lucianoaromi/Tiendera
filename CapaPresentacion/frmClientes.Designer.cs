using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboestado1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtindicecliente = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txttelefono1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlimpiarbusqueda = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // txtapellido1
            // 
            this.txtapellido1.Location = new System.Drawing.Point(11, 56);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(148, 20);
            this.txtapellido1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado:";
            // 
            // cboestado1
            // 
            this.cboestado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado1.FormattingEnabled = true;
            this.cboestado1.Location = new System.Drawing.Point(9, 265);
            this.cboestado1.Name = "cboestado1";
            this.cboestado1.Size = new System.Drawing.Size(148, 21);
            this.cboestado1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtindicecliente);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnlimpiar);
            this.panel1.Controls.Add(this.txtidcliente);
            this.panel1.Controls.Add(this.txttelefono1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtdireccion1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnombre1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 616);
            this.panel1.TabIndex = 20;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Black;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(23, 349);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(122, 35);
            this.btnguardar.TabIndex = 39;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // txtindicecliente
            // 
            this.txtindicecliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtindicecliente.ForeColor = System.Drawing.Color.White;
            this.txtindicecliente.Location = new System.Drawing.Point(99, 4);
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
            this.btneliminar.Location = new System.Drawing.Point(23, 471);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(122, 35);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.Text = "ELIMINAR";
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
            this.btnlimpiar.Location = new System.Drawing.Point(23, 411);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(122, 35);
            this.btnlimpiar.TabIndex = 37;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtidcliente.ForeColor = System.Drawing.Color.White;
            this.txtidcliente.Location = new System.Drawing.Point(137, 4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(31, 20);
            this.txtidcliente.TabIndex = 33;
            this.txtidcliente.Text = "0";
            this.txtidcliente.Visible = false;
            // 
            // txttelefono1
            // 
            this.txttelefono1.Location = new System.Drawing.Point(10, 211);
            this.txttelefono1.Name = "txttelefono1";
            this.txttelefono1.Size = new System.Drawing.Size(148, 20);
            this.txttelefono1.TabIndex = 30;
            this.txttelefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefono:";
            // 
            // txtdireccion1
            // 
            this.txtdireccion1.Location = new System.Drawing.Point(10, 159);
            this.txtdireccion1.Name = "txtdireccion1";
            this.txtdireccion1.Size = new System.Drawing.Size(148, 20);
            this.txtdireccion1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Direccion:";
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(11, 108);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(148, 20);
            this.txtnombre1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre:";
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(262, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(358, 22);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(148, 21);
            this.cbobusqueda.TabIndex = 24;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtbusqueda.Location = new System.Drawing.Point(522, 23);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(148, 20);
            this.txtbusqueda.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnlimpiarbusqueda);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Controls.Add(this.cbobusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 60);
            this.panel2.TabIndex = 27;
            // 
            // btnlimpiarbusqueda
            // 
            this.btnlimpiarbusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnlimpiarbusqueda.BackColor = System.Drawing.Color.Black;
            this.btnlimpiarbusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnlimpiarbusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnlimpiarbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbusqueda.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarbusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiarbusqueda.Image")));
            this.btnlimpiarbusqueda.Location = new System.Drawing.Point(755, 11);
            this.btnlimpiarbusqueda.Name = "btnlimpiarbusqueda";
            this.btnlimpiarbusqueda.Size = new System.Drawing.Size(60, 40);
            this.btnlimpiarbusqueda.TabIndex = 27;
            this.btnlimpiarbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarbusqueda.UseVisualStyleBackColor = false;
            this.btnlimpiarbusqueda.Click += new System.EventHandler(this.btnlimpiarbusqueda_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbuscar.BackColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(684, 11);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(60, 40);
            this.btnbuscar.TabIndex = 26;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseCompatibleTextRendering = true;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(17, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Clientes";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvdata);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(172, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 556);
            this.panel3.TabIndex = 28;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Apellido,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.Location = new System.Drawing.Point(0, 0);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(832, 556);
            this.dgvdata.TabIndex = 22;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick_1);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting_1);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdCliente";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 95;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 120;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 95;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboestado1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtapellido1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboestado1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdireccion1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelefono1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtindicecliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Button btnlimpiarbusqueda;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}