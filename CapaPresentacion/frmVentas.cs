using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        //Obtiene el usuario
        private Usuario _Usuario;

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            dgvdata.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //dgvdata.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dgvdata.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Gray; // Cambia el color de fondo de las filas alternas
            txtidproducto.Text = "0";
            txtcantidad.Value = 1;

        }

        private void btnbuscarcliente_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidcliente.Text = modal._Cliente.IdCliente.ToString();
                    
                    txtnombrecliente.Text = modal._Cliente.Nombre.ToString();
                    txtapellidocliente.Text = modal._Cliente.Apellido;

                }
                else
                {
                    txtcodigoproducto.Select();
                }


            }
        }

        private void btnbuscarproducto_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodigoproducto.Text = modal._Producto.Codigo.ToString();
                    txtnombreproducto.Text = modal._Producto.Nombre;
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtpreciounidad.Text = modal._Producto.Precio.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodigoproducto.Select();
                }


            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            // Verifica que se seleccione un producto
            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Para el formado de moneda sea correcto
            if (!decimal.TryParse(txtpreciounidad.Text, out precio))
            {
                MessageBox.Show("Precio - Formato de número incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciounidad.Select();
                return;
            }

            // Verifica si la cantidad es mayor al stock disponible o si es 0
            if (Convert.ToInt32(txtcantidad.Value) > Convert.ToInt32(txtstock.Text) || Convert.ToInt32(txtcantidad.Value) == 0)
            {
                MessageBox.Show("La cantidad no es válida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Analiza si el producto existe
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                );

                if (respuesta)
                {
                    // Agrega la condición para verificar si el stock es mayor a 0 antes de agregar al DataGridView
                    if (Convert.ToInt32(txtstock.Text) > 0)
                    {
                        dgvdata.Rows.Add(new object[]
                        {
                          txtidproducto.Text,
                          txtnombreproducto.Text,
                          precio.ToString("0.00"),
                          txtcantidad.Value.ToString(),
                          (txtcantidad.Value * precio).ToString("0.00")
                        });

                        calcularTotal();
                        limpiarproducto();
                        txtcodigoproducto.Select();
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar un producto con stock 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }




        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void limpiarproducto()
        {
            txtidproducto.Text = "0";
            txtcodigoproducto.Text = "";
            txtnombreproducto.Text = "";
            txtpreciounidad.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }



        private void btnventa_Click_1(object sender, EventArgs e)
        {

            if (txtapellidocliente.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido del cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre del cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("La lista de compra está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("Precio", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdocumentocliente.Text,
                ApellidoCliente = txtapellidocliente.Text,
                NombreCliente = txtnombrecliente.Text,
                MontoPago = Convert.ToDecimal(txtpagacon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text),
                DesMetPago = ((OpcionCombo)cbometodopago.SelectedItem).Texto,
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show(
                    "Número de venta generado: \n" + numeroDocumento + "\n\n¿Desea imprimir el PDF?",
                    "Mensaje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    // Llama al código para generar e imprimir el PDF
                    frmDetalleVenta form2 = new frmDetalleVenta();
                    form2.txtbusqueda.Text = numeroDocumento; // Pasa el número de venta al segundo formulario
                    form2.Show();
                }


                txtdocumentocliente.Text = "";
                txtapellidocliente.Text = "";
                txtnombrecliente.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagacon.Text = "";
                txtcambio.Text = "";
                txtnumventa.Text = numeroDocumento.ToString();

            }
            else
            {
                MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Consum. final", Texto = "Consum. final" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura B", Texto = "Factura B" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            cbometodopago.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Tarj. Credito" });
            cbometodopago.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Tarj. Debito" });
            cbometodopago.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Efectivo" });
            cbometodopago.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Tensferencia" });
            cbometodopago.Items.Add(new OpcionCombo() { Valor = 4, Texto = "QR" });
            //Especifica que solo se debe mostrar el dato de nombre "Texto"
            cbometodopago.DisplayMember = "Texto";
            //Maneja como informacion interna el dato de nombre "Valor"
            cbometodopago.ValueMember = "Valor";
            //Se selecciona siempre el indice 0
            cbometodopago.SelectedIndex = 0;
        }


        private void LimpiarCliente()
        {
            // Limpiar los TextBox después de agregar los datos
            txtnombrecliente.Clear();
            txtapellidocliente.Clear();
            txtdocumentocliente.Clear();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                if (e.ColumnIndex == 5)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = Properties.Resources.verde.Width;
                    var h = Properties.Resources.verde.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w)/2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h)/2;

                    e.Graphics.DrawImage(Properties.Resources.rojo, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name== "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                         Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),                        
                         Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                    
                    
                }
            }
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled= true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularcambio() 
        {
            if (txttotalpagar.Text.Trim() =="") 
            {
                MessageBox.Show("No existen productos en la venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagacon.Text.Trim() == "")
            {
                txtpagacon.Text = "0.00";
            }

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString(".00");
                }
            }
        }

        private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            limpiarproducto();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimpiarCliente();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {

            // Verifica si el TextBox está vacío
            if (string.IsNullOrEmpty(txtnumventa.Text))
            {
                MessageBox.Show("No se ha registrado ninguna venta para imprimir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Crea una instancia del segundo formulario
                frmDetalleVenta form2 = new frmDetalleVenta();

                // Pasa el contenido del TextBox de Form1 al TextBox de Form2
                form2.txtbusqueda.Text = txtnumventa.Text;

                // Muestra el segundo formulario
                form2.Show();
            }
        }
    }
}
