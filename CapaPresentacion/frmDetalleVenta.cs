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
        }


        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtfecha.ReadOnly = true;
            txttipodocumento.ReadOnly = true;
            txtusuarioapellido.ReadOnly = true;
            txtusuarionombre.ReadOnly = true;
            txtdoccliente.ReadOnly = true;
            txtapellidocliente.ReadOnly = true;
            txtnombrecliente.ReadOnly = true;
            txtmontototal.ReadOnly = true;
            txtmontopago.ReadOnly = true;
            txtmontocambio.ReadOnly = true;
            txtmetodopago.ReadOnly = true;

            txtbusqueda.Select();

            //___________________________________________________________
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                // Informacion del Vendedor
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuarioapellido.Text = oVenta.oUsuario.Apellido;
                txtusuarionombre.Text = oVenta.oUsuario2.Nombre;

                // Informacion del Cliente
                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtapellidocliente.Text = oVenta.ApellidoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                // Lista de productos vendidos
                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.Precio, dv.Cantidad, dv.SubTotal });
                }

                // Informacion de los distintos montos
                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");
                txtmetodopago.Text = oVenta.DesMetPago;

                // Desmarca cualquier fila seleccionada
                dgvdata.ClearSelection();
            }
        }


        // Boton que busca la venta segun el numero ingresado
        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                // Información del Vendedor
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuarioapellido.Text = oVenta.oUsuario.Apellido;
                txtusuarionombre.Text = oVenta.oUsuario2.Nombre;

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

                // Restablecer colores de todas las filas
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    row.DefaultCellStyle.BackColor = dgvdata.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvdata.DefaultCellStyle.ForeColor;
                }

                // Deseleccionar la primera fila
                if (dgvdata.Rows.Count > 0)
                {
                    dgvdata.ClearSelection();
                }

                // Información de los distintos montos
                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");
                txtmetodopago.Text = oVenta.DesMetPago;
            }
        }


        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            txtnumerodocumento.Text = "";
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuarioapellido.Text = "";

            txtdoccliente.Text = "";
            txtapellidocliente.Text = "";
            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
            txtmetodopago.Text = "";
        }

        private void btnpdf_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            
            //savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.ArduinoLogo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }

    }
}
