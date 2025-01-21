using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.verDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPago = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EstadoEntrega = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblapeusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblidusuario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblidrol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.btnbuscarpor = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarreporte = new System.Windows.Forms.Button();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(50, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 621);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verDetalle,
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.ApellidoCliente,
            this.MetodoPago,
            this.EstadoPago,
            this.EstadoEntrega,
            this.IdVenta});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.Location = new System.Drawing.Point(0, 150);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.Size = new System.Drawing.Size(959, 471);
            this.dgvdata.TabIndex = 11;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // verDetalle
            // 
            this.verDetalle.HeaderText = "Ver";
            this.verDetalle.MinimumWidth = 6;
            this.verDetalle.Name = "verDetalle";
            this.verDetalle.ReadOnly = true;
            this.verDetalle.Width = 40;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 90;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 80;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Nro documento";
            this.NumeroDocumento.MinimumWidth = 6;
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 80;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 80;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Vendedor";
            this.UsuarioRegistro.MinimumWidth = 6;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            this.UsuarioRegistro.Width = 150;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Cliente";
            this.ApellidoCliente.MinimumWidth = 6;
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            this.ApellidoCliente.Width = 150;
            // 
            // MetodoPago
            // 
            this.MetodoPago.HeaderText = "Metodo Pago";
            this.MetodoPago.MinimumWidth = 6;
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.ReadOnly = true;
            this.MetodoPago.Width = 90;
            // 
            // EstadoPago
            // 
            this.EstadoPago.HeaderText = "Pago";
            this.EstadoPago.Name = "EstadoPago";
            this.EstadoPago.ReadOnly = true;
            this.EstadoPago.Width = 70;
            // 
            // EstadoEntrega
            // 
            this.EstadoEntrega.HeaderText = "Entregado";
            this.EstadoEntrega.Name = "EstadoEntrega";
            this.EstadoEntrega.ReadOnly = true;
            this.EstadoEntrega.Width = 70;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = ".";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.lblapeusuario);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lblidusuario);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.lblidrol);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(959, 150);
            this.panel4.TabIndex = 28;
            // 
            // lblapeusuario
            // 
            this.lblapeusuario.BackColor = System.Drawing.Color.White;
            this.lblapeusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblapeusuario.Location = new System.Drawing.Point(689, 5);
            this.lblapeusuario.Name = "lblapeusuario";
            this.lblapeusuario.Size = new System.Drawing.Size(155, 20);
            this.lblapeusuario.TabIndex = 31;
            this.lblapeusuario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Reportes de Ventas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(776, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 79);
            this.button2.TabIndex = 33;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblidusuario
            // 
            this.lblidusuario.BackColor = System.Drawing.Color.White;
            this.lblidusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidusuario.Location = new System.Drawing.Point(850, 5);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.ReadOnly = true;
            this.lblidusuario.Size = new System.Drawing.Size(37, 20);
            this.lblidusuario.TabIndex = 16;
            this.lblidusuario.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(846, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 79);
            this.button3.TabIndex = 16;
            this.button3.Text = "Excel";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblidrol
            // 
            this.lblidrol.BackColor = System.Drawing.Color.White;
            this.lblidrol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidrol.Location = new System.Drawing.Point(893, 5);
            this.lblidrol.Name = "lblidrol";
            this.lblidrol.ReadOnly = true;
            this.lblidrol.Size = new System.Drawing.Size(37, 20);
            this.lblidrol.TabIndex = 17;
            this.lblidrol.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbobusqueda);
            this.groupBox2.Controls.Add(this.btnbuscarpor);
            this.groupBox2.Controls.Add(this.txtbusqueda);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(353, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 79);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(346, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 17;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtrar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(14, 44);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(119, 21);
            this.cbobusqueda.TabIndex = 15;
            // 
            // btnbuscarpor
            // 
            this.btnbuscarpor.BackColor = System.Drawing.Color.Black;
            this.btnbuscarpor.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnbuscarpor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnbuscarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarpor.ForeColor = System.Drawing.Color.Turquoise;
            this.btnbuscarpor.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarpor.Image")));
            this.btnbuscarpor.Location = new System.Drawing.Point(279, 15);
            this.btnbuscarpor.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscarpor.Name = "btnbuscarpor";
            this.btnbuscarpor.Size = new System.Drawing.Size(60, 55);
            this.btnbuscarpor.TabIndex = 15;
            this.btnbuscarpor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarpor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarpor.UseCompatibleTextRendering = true;
            this.btnbuscarpor.UseVisualStyleBackColor = false;
            this.btnbuscarpor.Click += new System.EventHandler(this.btnbuscarpor_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(145, 45);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(121, 20);
            this.txtbusqueda.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscarreporte);
            this.groupBox1.Controls.Add(this.txtfechafin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfechainicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por periodo";
            // 
            // btnbuscarreporte
            // 
            this.btnbuscarreporte.BackColor = System.Drawing.Color.Black;
            this.btnbuscarreporte.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnbuscarreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnbuscarreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarreporte.ForeColor = System.Drawing.Color.Turquoise;
            this.btnbuscarreporte.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarreporte.Image")));
            this.btnbuscarreporte.Location = new System.Drawing.Point(257, 15);
            this.btnbuscarreporte.Name = "btnbuscarreporte";
            this.btnbuscarreporte.Size = new System.Drawing.Size(60, 55);
            this.btnbuscarreporte.TabIndex = 10;
            this.btnbuscarreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarreporte.UseVisualStyleBackColor = false;
            this.btnbuscarreporte.Click += new System.EventHandler(this.btnbuscarreporte_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(133, 44);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(111, 20);
            this.txtfechafin.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(11, 44);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(111, 20);
            this.txtfechainicio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.txtindice);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 621);
            this.panel2.TabIndex = 34;
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
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnbuscarreporte;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Button btnbuscarpor;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lblidusuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblidrol;
        private System.Windows.Forms.TextBox lblapeusuario;
        private Button button2;
        private Panel panel4;
        private Label label3;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn verDetalle;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn ApellidoCliente;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewButtonColumn EstadoPago;
        private DataGridViewButtonColumn EstadoEntrega;
        private DataGridViewTextBoxColumn IdVenta;
        private Panel panel2;
        private TextBox txtindice;
        private TextBox txtid;
    }
}