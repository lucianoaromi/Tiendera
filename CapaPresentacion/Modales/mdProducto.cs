using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {

        public Producto _Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load_1(object sender, EventArgs e)
        {
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            // Configurar las propiedades después del bucle
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            // MOSTRAR SOLO PRODUCTOS ACTIVOS
            List<Producto> listaProducto = new CN_Producto().Listar().Where(p => p.Estado).ToList();

            foreach (Producto item in listaProducto)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.Precio,
                    item.Estado ==  true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                });
            }
        }


        // Método para normalizar y eliminar los acentos
        private string NormalizarTexto(string texto)
        {
            string normalizedString = texto.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }


        private void buscar()
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string busquedaNormalizada = NormalizarTexto(txtbusqueda.Text.Trim().ToUpper());

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null)
                    {
                        string cellValue = row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper();
                        string cellValueNormalizada = NormalizarTexto(cellValue);

                        if (cellValueNormalizada.Contains(busquedaNormalizada))
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
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------


        private void btnlimpiarbusqueda_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        //Envia los datos de la fila seleccionada en el datgridview hijo al padre
        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0) 
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Codigo = dgvdata.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvdata.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Precio = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["Precio"].Value.ToString()),

                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtbusqueda_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar();
            }
                
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
