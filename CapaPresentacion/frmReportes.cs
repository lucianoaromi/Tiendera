using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {

        private Usuario _Usuario;
        private int lastSelectedRow = -1;

        private CN_Reporte ventaNegocio;
        private object cadena;

        public frmReportes(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            dgvdata.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //dgvdata.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            //dgvdata.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Gray; // Cambia el color de fondo de las filas alternas

            ventaNegocio = new CN_Reporte(cadena);


        }



        private void frmReportes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
            lblidusuario.Text = Convert.ToString(_Usuario.IdUsuario);
            lblidrol.Text = Convert.ToString(_Usuario.oRol.IdRol);
            lblapeusuario.Text = $"{Convert.ToString(_Usuario.Apellido)}, {Convert.ToString(_Usuario.Nombre)}";


        }



        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();
            int idusuario = Convert.ToInt32(lblidusuario.Text);

            string fechaInicio = txtfechainicio.Value.ToString("dd/MM/yyyy");
            string fechaFin = txtfechafin.Value.ToString("dd/MM/yyyy");
            lista = new CN_Reporte().Venta(fechaInicio, fechaFin, idusuario);

            dgvdata.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                // Verifica las condiciones antes de agregar la fila
                if (lblidrol.Text == "2" || lblapeusuario.Text == rv.UsuarioRegistro) //|| lblapeusuario.Text == rv.UsuarioRegistro
                {
                    dgvdata.Rows.Add(new object[]
                    {
                        null, // Placeholder para la columna del botón
                        rv.FechaRegistro,
                        rv.TipoDocumento,
                        rv.NumeroDocumento,
                        rv.MontoTotal,
                        rv.UsuarioRegistro,
                        rv.ApellidoCliente,
                        rv.DesMetPago,
                        rv.EstadoEntrega, // Agregar el nuevo campo
                        rv.IdVenta,

                    });
                }
            
            }

            // Llama a la función para colorear las filas según el estado de entrega
            CargarColoresFilas();
        }

        // Función para colorear las filas según el estado de entrega
        private void CargarColoresFilas()
        {



            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                string estadoEntrega = row.Cells["EstadoEntrega"].Value.ToString();

                if (estadoEntrega == "Entregado")
                {
                    // Estado "Entregado", fila verde
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
                else if (estadoEntrega == "No entregado")
                {
                    // Estado "No entregado", fila roja
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    // Si no tiene un estado definido, lo dejamos en blanco o aplicamos otro color por defecto
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
            }

            // Configurar colores para que la selección no sea visible
            dgvdata.DefaultCellStyle.SelectionBackColor = dgvdata.DefaultCellStyle.BackColor;
            dgvdata.DefaultCellStyle.SelectionForeColor = dgvdata.DefaultCellStyle.ForeColor;

            // Opcional: Asegúrate de que las filas alternas también se vean igual
            dgvdata.AlternatingRowsDefaultCellStyle.SelectionBackColor = dgvdata.AlternatingRowsDefaultCellStyle.BackColor;
            dgvdata.AlternatingRowsDefaultCellStyle.SelectionForeColor = dgvdata.AlternatingRowsDefaultCellStyle.ForeColor;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en el botón de la columna que contiene los botones
            if (e.ColumnIndex == dgvdata.Columns["EstadoEntrega"].Index && e.RowIndex >= 0)
            {
                // Obtén el ID de la venta desde la primera columna
                int idVenta = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["IdVenta"].Value);

                // Obtén el estado actual desde la celda correspondiente
                string estadoActual = dgvdata.Rows[e.RowIndex].Cells["EstadoEntrega"].Value.ToString();

                // Determina el nuevo estado: si es "Entregado", lo cambiamos a "No entregado" y viceversa
                bool nuevoEstado = (estadoActual == "Entregado") ? false : true;

                // Llamamos a la capa de negocio para actualizar el estado
                string mensaje;
                bool resultado = ventaNegocio.ActualizarEstadoVenta(idVenta, nuevoEstado, out mensaje);

                // Si la actualización fue exitosa, actualiza la celda en el DataGridView
                if (resultado)
                {
                    dgvdata.Rows[e.RowIndex].Cells["EstadoEntrega"].Value = nuevoEstado ? "Entregado" : "No entregado";

                    // Cambiar el color de la fila según el estado
                    if (nuevoEstado)
                    {
                        // Estado "Entregado", fila verde
                        dgvdata.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                        dgvdata.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        // Estado "No entregado", fila roja
                        dgvdata.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        dgvdata.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }

                    MessageBox.Show("Estado actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //----------------------

            // Verifica si se hizo clic en una celda válida y si corresponde a la columna del botón
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvdata.Columns["verDetalle"].Index) // Reemplaza "BotonColumnName" con el nombre real de tu columna de botón
            {
                if (lastSelectedRow >= 0)
                {
                    // Restablece el color de la última fila seleccionada
                    dgvdata.Rows[lastSelectedRow].DefaultCellStyle.BackColor = dgvdata.DefaultCellStyle.BackColor;
                    dgvdata.Rows[lastSelectedRow].DefaultCellStyle.ForeColor = dgvdata.DefaultCellStyle.ForeColor;
                }

                // Obtén el valor de la tercera columna de la fila seleccionada
                string valorColumna = dgvdata.Rows[e.RowIndex].Cells[3].Value.ToString();

                // Crea una instancia del formulario Form2
                frmDetalleVenta form2 = new frmDetalleVenta();

                // Pasa el valor al TextBox del segundo formulario
                form2.txtbusqueda.Text = valorColumna;

                // Opcional: Si necesitas actualizar colores al cargar filas
                CargarColoresFilas();

                // Resalta la fila seleccionada
                dgvdata.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Cyan;
                dgvdata.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                // Actualiza el índice de la última fila seleccionada
                lastSelectedRow = e.RowIndex;

                // Muestra el segundo formulario
                form2.Show();
            }
        }

        //---------------------------------------------------------------------------------------------------------------

        private void btnbuscarpor_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        //Generar EXCEL
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

    }
}
