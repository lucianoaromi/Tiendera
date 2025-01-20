using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;


//Hace referencia a la carpeta "Utilidades" para el uso de la clase "OpcionCombo"
using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;
using System.Windows.Controls;
using System.Windows.Documents;
//using CapaPresentacion.Modales;

namespace CapaPresentacion
{
    public partial class frmAdmLicencia : Form
    {
        private CE_Licencia objcd_licencia;


        public frmAdmLicencia()
        {
           
            InitializeComponent();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboestado1.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado1.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            //Especifica que solo se debe mostrar el dato de nombre "Texto"
            cboestado1.DisplayMember = "Texto";
            //Maneja como informacion interna el dato de nombre "Valor"
            cboestado1.ValueMember = "Valor";
            //Se selecciona siempre el indice 0
            cboestado1.SelectedIndex = 0;


            //MOSTRAR TODOS LOS CLIENTES
            List<CE_Licencia> listaLicencia = new CN_AdmLicencia().Listar();

            foreach (CE_Licencia item in listaLicencia)
            {

                

                dgvdata.Rows.Add(new object[] {
                    "",
                    item.ID,
                    item.FechaInicio, // Formatear la fecha
                    item.DiasPermitidos,
                    item.Activado == true ? "Activo" : "No Activo",
                    item.Activado ==  true ? 1 : 0,                   
                    item.FechaActivacion, // Formatear la hora en formato HH:mm
                    item.CodigoActivacion,
 
                });
            }

            // Configurar el formato de la columna "FechaInicio" para mostrar solo la fecha
            dgvdata.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvdata.Columns["FechaActivacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }



        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Licencia objcd_licencia = new CE_Licencia()
            {
                ID = Convert.ToInt32(txtidcliente.Text),
                CodigoActivacion = txtcodactivacion.Text,


                Activado = Convert.ToInt32(((OpcionCombo)cboestado1.SelectedItem).Valor) == 1 ? true : false,
                FechaInicio = txtfecha.Value, // Solo la fecha
                FechaActivacion = txtfechainicio.Value,
                DiasPermitidos = Convert.ToInt32(txtDiasPermitido.Text),

                //Odontograma = txtodontograma.Text
            };

            if (objcd_licencia.ID == 0)
            {
                //Ejecuta el metodo Registrar de la Clase Licencia en la Cap de Neg con sus respectivos parametros, retornando el idlicencia
                int idclientegenerado = new CN_AdmLicencia().Registrar(objcd_licencia, out mensaje);

                if (idclientegenerado != 0)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                        "",
                        idclientegenerado,
                        txtfechainicio.Value.ToString("dd/MM/yyyy"), // Solo la hora
                        txtDiasPermitido.Text,
                        ((OpcionCombo)cboestado1.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)cboestado1.SelectedItem).Valor.ToString(),
                        txtfecha.Value.ToString("dd/MM/yyyy"), // Solo la fecha
                        txtcodactivacion.Text,

                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else // En caso de que sea una licencia existente el seleccionado se editara la mismo
            {
                bool resultado = new CN_AdmLicencia().Editar(objcd_licencia, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindicecliente.Text)];

                    row.Cells["ID"].Value = txtidcliente.Text;
                    row.Cells["FechaInicio"].Value = txtfecha.Value.ToString("dd/MM/yyyy"); // Solo la fecha
                    row.Cells["DiasPermitidos"].Value = txtidcliente.Text;
                    row.Cells["Activado"].Value = ((OpcionCombo)cboestado1.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado1.SelectedItem).Valor.ToString();                    
                    row.Cells["FechaActivacion"].Value = txtfechainicio.Value.ToString("dd/MM/yyyy"); // Solo la hora
                    row.Cells["CodigoActivacion"].Value = txtcodactivacion.Text;



                    Limpiar();
                    // Refrescar el DataGridView (opcional)
                    RefrescarDataGridView();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }



        private void Limpiar()
        {

            txtindicecliente.Text = "-1";
            txtidcliente.Text = "0";
            txtcodactivacion.Text = "";
            cboestado1.SelectedIndex = 0;
            txtfecha.Value = DateTime.Now;
            txtfechainicio.Value = DateTime.Now;
            txtDiasPermitido.Text = "";

            //El foco se va a el textbox documento
            txtcodactivacion.Select();
        }

        //Muestra la imagen de tilde en el DataGrid
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);              
                e.Handled = true;
            }
        }

        //Boton de DataGrid que trae los datos hacia los TextBox


        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidcliente.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la Licencia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Licencia objcd_licencia = new CE_Licencia()
                    {
                        ID = Convert.ToInt32(txtidcliente.Text)
                    };


                    bool respuesta = new CN_AdmLicencia().Eliminar(objcd_licencia, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindicecliente.Text));
                        txtindicecliente.Text = "-1";
                        txtidcliente.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna "btnseleccionar"
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    // Limpiar el color de todas las filas antes de marcar la seleccionada
                    foreach (DataGridViewRow row in dgvdata.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White; // Color predeterminado de fondo
                    }

                    // Marcar la fila seleccionada con color rojo
                    dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.LightCoral;

                    // Asignar datos de la fila seleccionada a los controles del formulario
                    txtindicecliente.Text = indice.ToString();
                    txtidcliente.Text = dgvdata.Rows[indice].Cells["ID"].Value.ToString();
                    // Asignar la fecha del DataGridView al DateTimePicker
                    DateTime fechaSeleccionada = Convert.ToDateTime(dgvdata.Rows[indice].Cells["FechaInicio"].Value);
                    txtfecha.Value = fechaSeleccionada;
                    txtDiasPermitido.Text = dgvdata.Rows[indice].Cells["DiasPermitidos"].Value.ToString();




                    DateTime horaSeleccionada = Convert.ToDateTime(dgvdata.Rows[indice].Cells["FechaActivacion"].Value);
                    txtfechainicio.Value = horaSeleccionada;

                    txtcodactivacion.Text = dgvdata.Rows[indice].Cells["CodigoActivacion"].Value.ToString();



                    // Asignar el estado al ComboBox
                    foreach (OpcionCombo oc in cboestado1.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado1.Items.IndexOf(oc);
                            cboestado1.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }



        // Método para refrescar el DataGridView
        private void RefrescarDataGridView()
        {
            // Limpiar las filas actuales
            dgvdata.Rows.Clear();

            // Obtener la lista de clientes actualizada
            List<CE_Licencia> listaLicencia = new CN_AdmLicencia().Listar();

            // Recargar los datos en el DataGridView
            foreach (CE_Licencia item in listaLicencia)
            {

                dgvdata.Rows.Add(new object[] {
                    "",
                    item.ID,
                    item.FechaInicio, // Formatear la fecha
                    item.DiasPermitidos,
                    item.Activado == true ? "Activo" : "No Activo",
                    item.Activado ==  true ? 1 : 0,
                    item.FechaActivacion, // Formatear la hora en formato HH:mm
                    item.CodigoActivacion,

                });
            }

            // Configurar el formato de la columna "FechaInicio" para mostrar solo la fecha
            dgvdata.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvdata.Columns["FechaActivacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
