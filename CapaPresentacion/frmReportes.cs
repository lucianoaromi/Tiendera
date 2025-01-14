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
            // Establece la altura predeterminada para todas las filas
            dgvdata.RowTemplate.Height = 27; // Cambia el valor según lo que necesites

            // Centramos solo las columnas que queremos
            dgvdata.Columns["verDetalle"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvdata.Columns["EstadoEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Agrega más columnas según sea necesario



            //dgvdata.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            //dgvdata.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Gray; // Cambia el color de fondo de las filas alternas

            ventaNegocio = new CN_Reporte(cadena);


        }



        private void frmReportes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                // Verifica si la columna no es del tipo DataGridViewButtonColumn
                if (!(columna is DataGridViewButtonColumn))
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
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
            CargarDatosVentas();

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

                // Cambiar el estilo del botón a gris (fondo y texto)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell is DataGridViewButtonCell)
                    {
                        DataGridViewButtonCell buttonCell = cell as DataGridViewButtonCell;
                        buttonCell.Style.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Italic);


                        buttonCell.Style.BackColor = System.Drawing.Color.Gray;  // Fondo gris
                        buttonCell.Style.ForeColor = System.Drawing.Color.White; // Texto en blanco para contraste
                        buttonCell.FlatStyle = FlatStyle.Flat;                  // Estilo plano para eliminar bordes
                        buttonCell.Style.SelectionBackColor = System.Drawing.Color.Gray; // Fondo gris cuando se selecciona
                        buttonCell.Style.SelectionForeColor = System.Drawing.Color.White; // Texto blanco cuando se selecciona


                    }
                }
            }

            // Configurar colores para que la selección no sea visible
            dgvdata.DefaultCellStyle.SelectionBackColor = dgvdata.DefaultCellStyle.BackColor;
            dgvdata.DefaultCellStyle.SelectionForeColor = dgvdata.DefaultCellStyle.ForeColor;

            // Opcional: Las filas alternas también se vean igual
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


            CargarDatosVentas();



            // Verifica si se hizo clic en una celda válida y si corresponde a la columna del botón
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvdata.Columns["verDetalle"].Index) 
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

        //ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº
        private void CargarDatosVentas()
        {
            // Crear la lista para almacenar los datos
            List<ReporteVenta> lista = new List<ReporteVenta>();

            // Obtener el ID del usuario y las fechas de inicio y fin
            int idusuario = Convert.ToInt32(lblidusuario.Text);
            string fechaInicio = txtfechainicio.Value.ToString("dd/MM/yyyy");
            string fechaFin = txtfechafin.Value.ToString("dd/MM/yyyy");

            // Llamar al método de la capa de negocio para obtener los datos
            lista = new CN_Reporte().Venta(fechaInicio, fechaFin, idusuario);

            // Ordenar la lista: "No entregado" primero, respetando el orden original para cada estado
            lista = lista.OrderBy(rv => rv.EstadoEntrega != "No entregado").ThenBy(rv => rv.FechaRegistro).ToList();

            // Limpiar las filas existentes en el DataGridView
            dgvdata.Rows.Clear();

            // Agregar las filas al DataGridView
            foreach (ReporteVenta rv in lista)
            {
                // Verifica las condiciones antes de agregar la fila
                if (lblidrol.Text == "2" || lblapeusuario.Text == rv.UsuarioRegistro)
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

        //ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº




        // Busca entre los resultados del Datagrid
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

        // Limpia la busqueda
        private void button1_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        // Generar EXCEL
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = new DataTable();

            // Excluir la primera y última columna
            for (int i = 1; i < dgvdata.Columns.Count - 1; i++)
            {
                dt.Columns.Add(dgvdata.Columns[i].HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible)
                {
                    List<object> valores = new List<object>();

                    // Excluir valores de la primera y última columna
                    for (int i = 1; i < dgvdata.Columns.Count - 1; i++)
                    {
                        valores.Add(row.Cells[i].Value?.ToString() ?? "");
                    }

                    dt.Rows.Add(valores.ToArray());
                }
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



        // Muestra Icono en el boton de ver detlle
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editaricon.Width;
                var h = Properties.Resources.editaricon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w)/2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h)/2;

                e.Graphics.DrawImage(Properties.Resources.editaricon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

    }
}
