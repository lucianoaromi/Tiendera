using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

using SpreadsheetColor = DocumentFormat.OpenXml.Spreadsheet.Color; //------ para los cuadros
using System.Globalization; //------
using DrawingColor = System.Drawing.Color; //---------- para cambiar color el fondo

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        public string TextBoxValue
        {
            get { return txtbusqueda.Text; }
            set { txtbusqueda.Text = value; }
        }

        public frmDetalleVenta()
        {
            InitializeComponent();

            groupBox1.Paint += groupBox1_Paint; // Sobrescribe el evento Paint del GroupBox //------
            groupBox2.Paint += groupBox1_Paint;
            groupBox4.Paint += groupBox1_Paint;
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtfecha.ReadOnly = true;
            txttipodocumento.ReadOnly = true;

            txtusuarionombre.ReadOnly = true;

            txtdoccliente.ReadOnly = true;
            txtapellidocliente.ReadOnly = true;
            txtnombrecliente.ReadOnly = true;
            txtmontototal.ReadOnly = true;
            txtmontopago.ReadOnly = true;
            txtmontocambio.ReadOnly = true;
            txtmetodopago.ReadOnly = true;

            // ✅ SOLO forzar texto negro sin cambiar estilos (fondo, headers, selección, etc.)
            dgvdata.DefaultCellStyle.ForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvdata.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            // Si también querés asegurar el header negro (sin cambiar fondo):
            // dgvdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            txtbusqueda.Select();

            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                // Informacion del Vendedor
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;

                // ✅ Nombre + Apellido en un solo textbox
                string nombreVendedor = oVenta.oUsuario2?.Nombre ?? "";
                string apellidoVendedor = oVenta.oUsuario?.Apellido ?? "";
                string vendedorCompleto = $"{nombreVendedor} {apellidoVendedor}".Trim();

                txtusuarionombre.Text = vendedorCompleto;

                // Informacion del Cliente
                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtapellidocliente.Text = oVenta.ApellidoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                // Lista de productos vendidos
                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] {
                        dv.oProducto.Nombre,
                        dv.Precio.ToString("N2"),
                        dv.Cantidad,
                        dv.SubTotal.ToString("N2")
                    });
                }

                // Informacion de los distintos montos
                txtmontototal.Text = oVenta.MontoTotal.ToString("#,0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("#,0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("#,0.00");
                txtmetodopago.Text = oVenta.DesMetPago;

                dgvdata.ClearSelection();

                this.BackColor = System.Drawing.Color.FromArgb(42, 47, 58);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void btnpdf_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy_(HHmmss)"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NRODOCUMENTO", txtnumerodocumento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTEA", txtapellidocliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTEN", txtnombrecliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdoccliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@METPAGO", txtmetodopago.Text);

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";

                string precioFormatted = Convert.ToDecimal(row.Cells["Precio"].Value).ToString("#,0.00").Replace(",", ".");
                filas += "<td>" + precioFormatted + "</td>";

                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";

                string subTotalFormatted = Convert.ToDecimal(row.Cells["SubTotal"].Value).ToString("#,0.00").Replace(",", ".");
                filas += "<td>" + subTotalFormatted + "</td>";

                filas += "</tr>";
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }

            string totalFormatted = total.ToString("#,0.00", CultureInfo.InvariantCulture);
            totalFormatted = totalFormatted.Replace(",", ".");

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", totalFormatted);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.tienda, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(10, 100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                // Información del Vendedor
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;

                string nombreVendedor = oVenta.oUsuario2?.Nombre ?? "";
                string apellidoVendedor = oVenta.oUsuario?.Apellido ?? "";
                txtusuarionombre.Text = $"{nombreVendedor} {apellidoVendedor}".Trim();

                // Información del Cliente
                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtapellidocliente.Text = oVenta.ApellidoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                // Lista de productos vendidos
                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.Precio, dv.Cantidad, dv.SubTotal });
                }

                if (dgvdata.Rows.Count > 0)
                    dgvdata.ClearSelection();

                // Información de los distintos montos
                txtmontototal.Text = oVenta.MontoTotal.ToString("#,0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("#,0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("#,0.00");
                txtmetodopago.Text = oVenta.DesMetPago;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            txtnumerodocumento.Text = "";
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuarionombre.Text = "";

            txtdoccliente.Text = "";
            txtapellidocliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
            txtmetodopago.Text = "";
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void groupBox1_Paint(object sender, PaintEventArgs e)  //------
        {
            GroupBox box = sender as GroupBox;
            if (box != null)
            {
                int borderWidth = 1;
                System.Drawing.Color borderColor = System.Drawing.Color.White;

                e.Graphics.Clear(this.BackColor);

                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawRectangle(pen, box.ClientRectangle.X, box.ClientRectangle.Y + 6,
                                              box.ClientRectangle.Width - 1, box.ClientRectangle.Height - 8);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    box.Text,
                    box.Font,
                    new Point(box.ClientRectangle.X + 10, box.ClientRectangle.Y),
                    box.ForeColor,
                    TextFormatFlags.Default);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------
    }
}
